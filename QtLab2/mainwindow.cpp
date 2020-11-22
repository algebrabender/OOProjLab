#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
    , m_chartDoc(new ChartDoc())
{
    ui->setupUi(this);
    ui->centralwidget->referenciranje(m_chartDoc);
    connect(m_chartDoc, SIGNAL(chartDataChanged()), ui->centralwidget, SLOT(onChartDataChanged()));
}

MainWindow::~MainWindow()
{
    delete ui;
}


void MainWindow::on_actionLoad_Chart_triggered()
{
    QString fname = QFileDialog::getOpenFileName(this, this->windowTitle(), QDir::currentPath(), "Text Files (*.txt)");
    if (!fname.isEmpty())
        m_chartDoc->loadChartFromFile(fname);
    emit m_chartDoc->chartDataChanged();
}

void MainWindow::on_actionSave_Chart_triggered()
{
    QString fname = QFileDialog::getSaveFileName(this, this->windowTitle(), QDir::currentPath(), "Text Files (*.txt)");
    if (!fname.isEmpty())
        m_chartDoc->saveChartToFile(fname);
    else
        on_actionSave_Chart_triggered();
}
