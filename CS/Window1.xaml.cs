﻿using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using DevExpress.Wpf.Grid;

namespace DXGrid_FocusedRow {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();

            List<TestData> list = new List<TestData>();
            for (int i = 0; i < 100; i++) {
                list.Add(new TestData() {
                    Number1 = i,
                    Number2 = i * 10,
                    Text1 = "row " + i,
                    Text2 = "ROW " + i
                });
            }

            DataContext = list;
        }
    }

    public class TestData {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
    }

    public class MyView : TableView {
        public static readonly DependencyProperty FocusedRowProperty =
            DependencyProperty.Register("FocusedRow", typeof(object), typeof(MyView), 
            new UIPropertyMetadata(null, OnFocusedRowChanged));

        static void OnFocusedRowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            ((MyView)d).OnFocusedRowChanged();
        }

        public new object FocusedRow {
            get { return GetValue(FocusedRowProperty); }
            set { SetValue(FocusedRowProperty, value); }
        }

        public MyView() {
            FocusedRowChanged += new FocusedRowChangedEventHandler(OnFocusedRowChanged);
        }

        void OnFocusedRowChanged() {
            FocusedRowHandle = Grid.DataController.FindRowByRowValue(FocusedRow);
        }

        void OnFocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            FocusedRow = Grid.GetRow(FocusedRowHandle);
        }
    }
}
