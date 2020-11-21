#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QFileDialog>
#include "chartdoc.h"
#include "chartview.h"
#include <QGridLayout>

QT_BEGIN_NAMESPACE
namespace Ui { class MainWindow; }
QT_END_NAMESPACE

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

private slots:
    void on_actionLoad_Chart_triggered();
    void on_actionSave_Chart_triggered();

private:
    Ui::MainWindow *ui;
public:
    ChartDoc* m_chartDoc;
};
#endif // MAINWINDOW_H
