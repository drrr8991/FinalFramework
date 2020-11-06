﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TestEventListenerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TestEventListener), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("SetOnFinished", new LuaCSFunction(SetOnFinished));
		L.RegFunction("__eq", new LuaCSFunction(op_Equality));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegVar("onClick", new LuaCSFunction(get_onClick), new LuaCSFunction(set_onClick));
		L.RegVar("TestFunc", new LuaCSFunction(get_TestFunc), new LuaCSFunction(set_TestFunc));
		L.RegVar("onClickEvent", new LuaCSFunction(get_onClickEvent), new LuaCSFunction(set_onClickEvent));
		L.RegFunction("OnClick", new LuaCSFunction(TestEventListener_OnClick));
		L.RegFunction("VoidDelegate", new LuaCSFunction(TestEventListener_VoidDelegate));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetOnFinished(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<TestEventListener.OnClick>(L, 2))
			{
				TestEventListener obj = (TestEventListener)ToLua.CheckObject<TestEventListener>(L, 1);
				TestEventListener.OnClick arg0 = (TestEventListener.OnClick)ToLua.ToObject(L, 2);
				obj.SetOnFinished(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<TestEventListener.VoidDelegate>(L, 2))
			{
				TestEventListener obj = (TestEventListener)ToLua.CheckObject<TestEventListener>(L, 1);
				TestEventListener.VoidDelegate arg0 = (TestEventListener.VoidDelegate)ToLua.ToObject(L, 2);
				obj.SetOnFinished(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TestEventListener.SetOnFinished");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestEventListener obj = (TestEventListener)o;
			TestEventListener.OnClick ret = obj.onClick;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TestFunc(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestEventListener obj = (TestEventListener)o;
			System.Func<bool> ret = obj.TestFunc;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TestFunc on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onClickEvent(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(TestEventListener.OnClick)));        
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestEventListener obj = (TestEventListener)o;
			TestEventListener.OnClick arg0 = (TestEventListener.OnClick)ToLua.CheckDelegate<TestEventListener.OnClick>(L, 2);

            if (!object.ReferenceEquals(obj.onClick, arg0))
            {
                if (obj.onClick != null) obj.onClick.SubRef();
                obj.onClick = arg0;
            }
            
            return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_TestFunc(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestEventListener obj = (TestEventListener)o;
			System.Func<bool> arg0 = (System.Func<bool>)ToLua.CheckDelegate<System.Func<bool>>(L, 2);
			obj.TestFunc = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TestFunc on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onClickEvent(IntPtr L)
	{
		try
		{
			TestEventListener obj = (TestEventListener)ToLua.CheckObject<TestEventListener>(L, 1);
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'TestEventListener.onClickEvent' can only appear on the left hand side of += or -= when used outside of the type 'TestEventListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				TestEventListener.OnClick ev = (TestEventListener.OnClick)arg0.func;                
				obj.onClickEvent += ev;                          
            }
			else if (arg0.op == EventOp.Sub)
			{
				TestEventListener.OnClick ev = (TestEventListener.OnClick)arg0.func;                
                obj.onClickEvent -= ev;                
            }

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestEventListener_OnClick(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<TestEventListener.OnClick>.Create(func);
				ToLua.Push(L, arg1);
                func.Dispose();
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<TestEventListener.OnClick>.Create(func, self);
                func.Dispose();
                self.Dispose();
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestEventListener_VoidDelegate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<TestEventListener.VoidDelegate>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<TestEventListener.VoidDelegate>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

