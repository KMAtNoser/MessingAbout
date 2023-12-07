import unittest
from PythonPackage import TempClass


class TempTest(unittest.TestCase):
    
    def setUp(self) -> None:
        self.testInstance = TempClass()

    def tearDown(self) -> None:
        pass

    def test_TempClass_Function1_Returns10(self):
        result = self.testInstance.Function1()
        expected = 10
        self.assertEqual(result, expected)
