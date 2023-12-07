from PythonPackage import TempClass

def test_TempClass_Function1_Returns10_PyTest():
    testInstance = TempClass()
    result = testInstance.Function1()
    expected = 10
    assert result == expected