/*
 * Создано в SharpDevelop.
 * Пользователь: Konstantin
 * Дата: 27.12.2021
 * Время: 13:19
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using NUnit.Framework;

namespace Test_Task.U_tests
{
	[TestFixture]
	public class UTNegativEdgeTriangle
	{
		[Test]
		public void TestMethod()
		{
			// TODO: Add your test.
			Triangle TestTriangle = new Triangle(4, 3, 5);
			Triangle NegativTestTriangle = new Triangle(-4, -3, -5);
			
			TestTriangle.AnyTriangleSquare = new GetSquareOnEdges();
			NegativTestTriangle.AnyTriangleSquare = new GetSquareOnEdges();			
			Assert.AreEqual(TestTriangle.GetI_shapeSquare(), NegativTestTriangle.GetI_shapeSquare());
			
		}
	}
}
