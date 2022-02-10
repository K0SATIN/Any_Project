/*
 * Создано в SharpDevelop.
 * Пользователь: Konstantin
 * Дата: 30.12.2021
 * Время: 10:14
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using NUnit.Framework;

namespace Тестовое_4.Тесты
{
	[TestFixture]
	public class UTIsRigthTriabgle
	{
		[Test]
		public void TestMethod()
		{
			// TODO: Add your test.
			Triangle RigthTriabgle = new Triangle(4, 3, 5);
			Triangle NotRigthTriabgle = new Triangle(4, 3, 6);
			
			Assert.AreEqual(RigthTriabgle.IsRightTriangle(), true);
			Assert.AreEqual(NotRigthTriabgle.IsRightTriangle(), false);
			
		}
	}
}
