﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_EventSystems_StandaloneInputModuleWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.EventSystems.StandaloneInputModule), typeof(UnityEngine.EventSystems.PointerInputModule));
		L.RegFunction("UpdateModule", UpdateModule);
		L.RegFunction("IsModuleSupported", IsModuleSupported);
		L.RegFunction("ShouldActivateModule", ShouldActivateModule);
		L.RegFunction("ActivateModule", ActivateModule);
		L.RegFunction("DeactivateModule", DeactivateModule);
		L.RegFunction("Process", Process);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("forceModuleActive", get_forceModuleActive, set_forceModuleActive);
		L.RegVar("inputActionsPerSecond", get_inputActionsPerSecond, set_inputActionsPerSecond);
		L.RegVar("repeatDelay", get_repeatDelay, set_repeatDelay);
		L.RegVar("horizontalAxis", get_horizontalAxis, set_horizontalAxis);
		L.RegVar("verticalAxis", get_verticalAxis, set_verticalAxis);
		L.RegVar("submitButton", get_submitButton, set_submitButton);
		L.RegVar("cancelButton", get_cancelButton, set_cancelButton);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateModule(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)ToLua.CheckObject<UnityEngine.EventSystems.StandaloneInputModule>(L, 1);
			obj.UpdateModule();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsModuleSupported(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)ToLua.CheckObject<UnityEngine.EventSystems.StandaloneInputModule>(L, 1);
			bool o = obj.IsModuleSupported();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShouldActivateModule(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)ToLua.CheckObject<UnityEngine.EventSystems.StandaloneInputModule>(L, 1);
			bool o = obj.ShouldActivateModule();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ActivateModule(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)ToLua.CheckObject<UnityEngine.EventSystems.StandaloneInputModule>(L, 1);
			obj.ActivateModule();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DeactivateModule(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)ToLua.CheckObject<UnityEngine.EventSystems.StandaloneInputModule>(L, 1);
			obj.DeactivateModule();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Process(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)ToLua.CheckObject<UnityEngine.EventSystems.StandaloneInputModule>(L, 1);
			obj.Process();
			return 0;
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
	static int get_forceModuleActive(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)o;
			bool ret = obj.forceModuleActive;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index forceModuleActive on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_inputActionsPerSecond(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)o;
			float ret = obj.inputActionsPerSecond;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index inputActionsPerSecond on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_repeatDelay(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)o;
			float ret = obj.repeatDelay;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index repeatDelay on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_horizontalAxis(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)o;
			string ret = obj.horizontalAxis;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index horizontalAxis on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_verticalAxis(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)o;
			string ret = obj.verticalAxis;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index verticalAxis on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_submitButton(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)o;
			string ret = obj.submitButton;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index submitButton on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cancelButton(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)o;
			string ret = obj.cancelButton;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cancelButton on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_forceModuleActive(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.forceModuleActive = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index forceModuleActive on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_inputActionsPerSecond(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.inputActionsPerSecond = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index inputActionsPerSecond on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_repeatDelay(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.repeatDelay = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index repeatDelay on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_horizontalAxis(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.horizontalAxis = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index horizontalAxis on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_verticalAxis(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.verticalAxis = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index verticalAxis on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_submitButton(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.submitButton = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index submitButton on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cancelButton(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.StandaloneInputModule obj = (UnityEngine.EventSystems.StandaloneInputModule)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.cancelButton = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cancelButton on a nil value");
		}
	}
}
