/*
 * Создано в SharpDevelop.
 * Пользователь: Konstantin
 * Дата: 28.12.2021
 * Время: 14:49
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using NUnit.Framework;

namespace Test_Task.U_tests
{
	[TestFixture]
	public class UTCircleSquare
	{
		[Test]
		public void TestMethod()
		{
			// TODO: Add your test.
			Circle TestCircle = new Circle(10);		
			TestCircle.CircleSquare = new CircleSquareR();
			
			Assert.AreEqual(314, TestCircle.GetI_shapeSquare());
		}
	}
}
