/*
 * Создано в SharpDevelop.
 * Пользователь: Konstantin
 * Дата: 28.12.2021
 * Время: 14:52
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using NUnit.Framework;

namespace Тестовое_4.Тесты
{
	[TestFixture]
	public class UTTriangleSquere
	{
		[Test]
		public void TestMethod()
		{
			// TODO: Add your test.
			Triangle TestTriangle = new Triangle(4, -3, 5);
			
			TestTriangle.AnyTriangleSquare = new GetSquareOnEdges();
			
			Assert.AreEqual(TestTriangle.GetI_shapeSquare(), 6);
		}
	}
}
