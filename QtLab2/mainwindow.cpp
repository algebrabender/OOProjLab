#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
    , m_chartDoc(new ChartDoc(this))
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}


void MainWindow::on_actionLoad_Chart_triggered()
{
    QString fname = QFileDialog::getOpenFileName(this, this->windowTitle(), "D:\\School and Uni\\ELFAK\\OOP\\Qt\\ChartViewer", "Text Files (*.txt)");
    if (!fname.isEmpty())
        m_chartDoc->loadChartFromFile(fname);
}

void MainWindow::on_actionSave_Chart_triggered()
{
    QString fname = QFileDialog::getSaveFileName(this, this->windowTitle(), "D:\\School and Uni\\ELFAK\\OOP\\Qt\\ChartViewer", "Text Files (*.txt)");
    if (!fname.isEmpty())
        m_chartDoc->saveChartToFile(fname);
    else
        on_actionSave_Chart_triggered();
}
