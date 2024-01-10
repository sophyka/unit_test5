using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestLab5
{
    [TestClass]
    public class LineTests
    {
        [TestMethod]
        public void TestEquals_SameLineInstance_ShouldBeEqual()
        {
            
            Dot startDot = new Dot(1.0f, 2.0f);
            Dot endDot = new Dot(3.0f, 4.0f);
            Line line = new Line(startDot, endDot, "black");

            Assert.AreEqual(line, line, "Same Line instance should be equal.");
        }

        [TestMethod]
        public void TestEquals_EqualLines_ShouldBeEqual()
        {

            Line line1 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");
            Line line2 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");


            Assert.AreEqual(line1, line2, "Equal Lines should be equal.");
        }

        [TestMethod]
        public void TestEquals_DifferentLines_ShouldNotBeEqual()
        {

            Line line1 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");
            Line line2 = new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black");

            Assert.AreNotEqual(line1, line2, "Different Lines should not be equal.");
        }

        [TestMethod]
        public void TestEquals_ReversedEndDots_ShouldBeEqual()
        {
            Line line1 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");
            Line line2 = new Line(new Dot(3.0f, 4.0f), new Dot(1.0f, 2.0f), "black");

            Assert.AreEqual(line1, line2, "Lines with reversed end dots should be equal.");
        }

        [TestMethod]
        public void TestGetHashCode_EqualLines_ShouldHaveSameHashCode()
        {
            Line line1 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");
            Line line2 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");

            Assert.AreEqual(line1.GetHashCode(), line2.GetHashCode(), "Equal Lines should have the same hash code.");
        }

        [TestMethod]
        public void TestGetHashCode_DifferentLines_ShouldHaveDifferentHashCodes()
        {
            Line line1 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");
            Line line2 = new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black");

            Assert.AreNotEqual(line1.GetHashCode(), line2.GetHashCode(), "Different Lines should have different hash codes.");
        }

        [TestMethod]
        public void TestToString_ShouldReturnFormattedString()
        {
            Line line = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");

            string result = line.ToString();

            Assert.AreEqual("(  1:  2)--->(  3:  4) | Color: black", result, "ToString should return a formatted string.");
        }
    }
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void TestEquals_SameFigureInstance_ShouldBeEqual()
        {
            Figure figure = new Figure();

            Assert.AreEqual(figure, figure, "Same Figure instance should be equal.");
        }

        [TestMethod]
        public void TestEquals_EqualFigures_ShouldBeEqual()
        {
            Figure figure1 = new Figure();
            Figure figure2 = new Figure();

            Line line1 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");
            Line line2 = new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black");

            figure1.AddLine(line1);
            figure1.AddLine(line2);

            figure2.AddLine(new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black"));
            figure2.AddLine(new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black"));

            Assert.AreEqual(figure1, figure2, "Equal Figures should be equal.");
        }

        [TestMethod]
        public void TestEquals_DifferentFigures_ShouldNotBeEqual()
        {
            Figure figure1 = new Figure();
            Figure figure2 = new Figure();

            Line line1 = new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black");
            Line line2 = new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black");

            figure1.AddLine(line1);
            figure1.AddLine(line2);

            figure2.AddLine(new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black"));
            figure2.AddLine(new Line(new Dot(9.0f, 10.0f), new Dot(11.0f, 12.0f), "black"));

            Assert.AreNotEqual(figure1, figure2, "Different Figures should not be equal.");
        }

        [TestMethod]
        public void TestGetHashCode_EqualFigures_ShouldHaveSameHashCode()
        {
            Figure figure1 = new Figure();
            Figure figure2 = new Figure();

            figure1.AddLine(new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black"));
            figure1.AddLine(new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black"));

            figure2.AddLine(new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black"));
            figure2.AddLine(new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black"));

            Assert.AreEqual(figure1.GetHashCode(), figure2.GetHashCode(), "Equal Figures should have the same hash code.");
        }

        [TestMethod]
        public void TestGetHashCode_DifferentFigures_ShouldHaveDifferentHashCodes()
        {
            Figure figure1 = new Figure();
            Figure figure2 = new Figure();

            figure1.AddLine(new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black"));
            figure1.AddLine(new Line(new Dot(5.0f, 6.0f), new Dot(7.0f, 8.0f), "black"));

            figure2.AddLine(new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "black"));
            figure2.AddLine(new Line(new Dot(9.0f, 10.0f), new Dot(11.0f, 12.0f), "black"));

            Assert.AreNotEqual(figure1.GetHashCode(), figure2.GetHashCode(), "Different Figures should have different hash codes.");
        }
    }
    [TestClass]
    public class DotTests
    {
        [TestMethod]
        public void TestEquals_SameDotInstance_ShouldBeEqual()
        {
            Dot dot = new Dot(1.0f, 2.0f);

            Assert.AreEqual(dot, dot, "Same Dot instance should be equal.");
        }

        [TestMethod]
        public void TestEquals_EqualDots_ShouldBeEqual()
        {
            Dot dot1 = new Dot(1.0f, 2.0f);
            Dot dot2 = new Dot(1.0f, 2.0f);

            Assert.AreEqual(dot1, dot2, "Equal Dots should be equal.");
        }

        [TestMethod]
        public void TestEquals_DifferentDots_ShouldNotBeEqual()
        {
            Dot dot1 = new Dot(1.0f, 2.0f);
            Dot dot2 = new Dot(3.0f, 4.0f);

            Assert.AreNotEqual(dot1, dot2, "Different Dots should not be equal.");
        }

        [TestMethod]
        public void TestEquals_NullObject_ShouldNotBeEqual()
        {
            Dot dot = new Dot(1.0f, 2.0f);

            Assert.AreNotEqual(dot, null, "Dot should not be equal to null.");
        }

        [TestMethod]
        public void TestGetHashCode_EqualDots_ShouldHaveSameHashCode()
        {
            Dot dot1 = new Dot(1.0f, 2.0f);
            Dot dot2 = new Dot(1.0f, 2.0f);

            Assert.AreEqual(dot1.GetHashCode(), dot2.GetHashCode(), "Equal Dots should have the same hash code.");
        }

        [TestMethod]
        public void TestGetHashCode_DifferentDots_ShouldHaveDifferentHashCodes()
        {
            Dot dot1 = new Dot(1.0f, 2.0f);
            Dot dot2 = new Dot(3.0f, 4.0f);

            Assert.AreNotEqual(dot1.GetHashCode(), dot2.GetHashCode(), "Different Dots should have different hash codes.");
        }
    }
    [TestClass]
    public class DatabaseManagerTests
    {
        private DatabaseManager databaseManager;

        [TestInitialize]
        public void Setup()
        {
            databaseManager = new DatabaseManager("test_database.sqlite");
        }

        [TestMethod]
        public void TestSaveAndLoadTurtleData_ShouldMaintainObjectState()
        {
            TurtleStorage originalData = new TurtleStorage
            TurtleStorage originalData = new TurtleStorage
            {
                X = 10.5f,
                Y = 20.3f,
                Angle = 90,
                PenDown = true,
                PenColor = "blue",
                Dots = new List<Dot> { new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f) },
                Lines = new List<Line> { new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "red") },
                Figures = new List<Figure> { new Figure() },
                CurrentFigure = new Figure(),
                Steps = new List<string> { "step1", "step2" }
            };

            databaseManager.SaveTurtleData(originalData);
            TurtleStorage loadedData = databaseManager.LoadTurtleData();

            Assert.AreEqual(originalData.X, loadedData.X);
            Assert.AreEqual(originalData.Y, loadedData.Y);
            Assert.AreEqual(originalData.Angle, loadedData.Angle);
            Assert.AreEqual(originalData.PenDown, loadedData.PenDown);
            Assert.AreEqual(originalData.PenColor, loadedData.PenColor);
            CollectionAssert.AreEqual(originalData.Dots, loadedData.Dots);
            CollectionAssert.AreEqual(originalData.Lines, loadedData.Lines);
            CollectionAssert.AreEqual(originalData.Figures, loadedData.Figures);
            CollectionAssert.AreEqual(originalData.CurrentFigure.Lines, loadedData.CurrentFigure.Lines);
            CollectionAssert.AreEqual(originalData.Steps, loadedData.Steps);
        }

        [TestMethod]
        public void TestClearDatabase_ShouldRemoveData()
        {
            TurtleStorage originalData = new TurtleStorage
            {
                X = 10.5f,
                Y = 20.3f,
                Angle = 90,
                PenDown = true,
                PenColor = "blue",
                Dots = new List<Dot> { new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f) },
                Lines = new List<Line> { new Line(new Dot(1.0f, 2.0f), new Dot(3.0f, 4.0f), "red") },
                Figures = new List<Figure> { new Figure() },
                CurrentFigure = new Figure(),
                Steps = new List<string> { "step1", "step2" }
            };

            databaseManager.SaveTurtleData(originalData);
            databaseManager.ClearDatabase();
            TurtleStorage loadedData = databaseManager.LoadTurtleData();

            // Assert
            Assert.AreEqual(0, loadedData.Dots.Count);
            Assert.AreEqual(0, loadedData.Lines.Count);
            Assert.AreEqual(0, loadedData.Figures.Count);
            Assert.AreEqual(0, loadedData.CurrentFigure.Lines.Count);
            Assert.AreEqual(0, loadedData.Steps.Count);
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists("test_database.sqlite"))
            {
                File.Delete("test_database.sqlite");
            }
        }
    }
    [TestClass]
    public class TurtleTests
    {
        private Turtle turtle;

        [TestInitialize]
        public void Setup()
        {
            turtle = new Turtle();
        }

        [TestMethod]
        public void TestProcessCommand_Move_ShouldUpdateCoordinates()
        {
            string command = "move 5";

            turtle.ProcessCommand(command);

            Assert.AreEqual(5, turtle.x);
            Assert.AreEqual(0, turtle.y);
        }

        [TestMethod]
        public void TestProcessCommand_PenDown_ShouldAddLine()
        {
            string command = "pd";

            turtle.ProcessCommand(command);

            Assert.IsTrue(turtle.getLines().Count > 0);
        }
        [TestMethod]
        public void TestProcessCommand_Angle_ShouldChangeAngle()
        {
            string command = "angle 90";

            turtle.ProcessCommand(command);

            Assert.AreEqual(90, turtle.angle);
        }

        [TestMethod]
        public void TestProcessCommand_Color_ShouldChangePenColor()
        {
            string command = "color red";

            turtle.ProcessCommand(command);

            Assert.AreEqual("red", turtle.penColor);
        }

        [TestMethod]
        public void TestSaveToFileAndLoadFromFile_ShouldMaintainObjectState()
        {
            turtle.ProcessCommand("pd");
            turtle.ProcessCommand("move 5");
            turtle.ProcessCommand("angle 90");
            turtle.ProcessCommand("color blue");

            turtle.SaveToFile("json");
            Turtle loadedTurtle = new Turtle();
            loadedTurtle.LoadFromFile("json");

            Assert.AreEqual(turtle.x, loadedTurtle.x);
            Assert.AreEqual(turtle.y, loadedTurtle.y);
            Assert.AreEqual(turtle.angle, loadedTurtle.angle);
            Assert.AreEqual(turtle.penDown, loadedTurtle.penDown);
            Assert.AreEqual(turtle.penColor, loadedTurtle.penColor);
            Assert.AreEqual(turtle.getLines().Count, loadedTurtle.getLines().Count);
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists("storage.json"))
            {
                File.Delete("storage.json");
            }
            if (File.Exists("turtle_storage.sqlite"))
            {
                File.Delete("turtle_storage.sqlite");
            }
        }
    }
    [TestClass]
    public class TurtleStorageTests
    {
        [TestMethod]
        public void TestProperties_SetAndGetProperties_ShouldMatch()
        {
            float expectedX = 10.5f;
            float expectedY = 20.8f;
            int expectedAngle = 45;
            bool expectedPenDown = true;
            string expectedPenColor = "blue";
            List<Dot> expectedDots = new List<Dot> { new Dot(1, 1), new Dot(2, 2) };
            List<Line> expectedLines = new List<Line> { new Line(new Dot(1, 1), new Dot(2, 2), "red") };
            List<Figure> expectedFigures = new List<Figure> { new Figure() };
            Figure expectedCurrentFigure = new Figure();
            ObservableCollection<string> expectedSteps = new ObservableCollection<string> { "Step 1", "Step 2" };

            TurtleStorage turtleStorage = new TurtleStorage
            {
                X = expectedX,
                Y = expectedY,
                Angle = expectedAngle,
                PenDown = expectedPenDown,
                PenColor = expectedPenColor,
                Dots = expectedDots,
                Lines = expectedLines,
                Figures = expectedFigures,
                CurrentFigure = expectedCurrentFigure,
                Steps = expectedSteps
            };

            Assert.AreEqual(expectedX, turtleStorage.X);
            Assert.AreEqual(expectedY, turtleStorage.Y);
            Assert.AreEqual(expectedAngle, turtleStorage.Angle);
            Assert.AreEqual(expectedPenDown, turtleStorage.PenDown);
            Assert.AreEqual(expectedPenColor, turtleStorage.PenColor);
            CollectionAssert.AreEqual(expectedDots, turtleStorage.Dots);
            CollectionAssert.AreEqual(expectedLines, turtleStorage.Lines);
            CollectionAssert.AreEqual(expectedFigures, turtleStorage.Figures);
            Assert.AreSame(expectedCurrentFigure, turtleStorage.CurrentFigure);
            CollectionAssert.AreEqual(expectedSteps, turtleStorage.Steps);
        }
    }
    [TestClass]
    public class MainWindowTests
    {
        [TestMethod]
        public void ExecuteCommand_ValidCommand_ShouldNotThrowException()
        {
            MainWindow mainWindow = new MainWindow();

            Assert.IsFalse(mainWindow.TurtleView.PenDown);  
            Assert.AreEqual(0, mainWindow.TurtleView.x);   
            Assert.AreEqual(0, mainWindow.TurtleView.y);   

            mainWindow.ExecuteCommand("pd");

            Assert.IsTrue(mainWindow.TurtleView.PenDown);
        }

        [TestMethod]
        public void DrawCanvas_ValidCommand_ShouldUpdateCanvasChildren()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.TurtleView.ProcessCommand("pd");   

            mainWindow.DrawCanvas();

            Assert.AreEqual(2, mainWindow.drawingCanvas.Children.Count);   
        }

        [TestMethod]
        public void DrawCanvas_InvalidCommand_ShouldShowMessageBox()
        {
            
            MainWindow mainWindow = new MainWindow();
            mainWindow.TurtleView.ProcessCommand("invalidCommand");   

           
            mainWindow.DrawCanvas();

             
            MessageBox.Show("Ошибка выполнения команды:");   
        }
    }

}
