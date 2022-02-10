/*
 * Создано в SharpDevelop.
 * Пользователь: Konstantin
 * Дата: 27.12.2021
 * Время: 11:16
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using NUnit.Framework;

namespace Тестовое_4
{
	[TestFixture]
	public class NegativEdge
	{
		[Test]
		public void TestMethod()
		{
			// TODO: Add your test.
			Circle TestCircle = new Circle(4);
			Circle NegativTestCircle = new Circle(-4);			
			TestCircle.CircleSquare = new CircleSquareR();
			NegativTestCircle.CircleSquare = new CircleSquareR();
			
			Assert.AreEqual(TestCircle.GetI_shapeSquare(), NegativTestCircle.GetI_shapeSquare());
		}
	}
}
