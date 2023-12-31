// Decompiled with JetBrains decompiler
// Type: ProjectM.KeyboardLocaleDetection
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class KeyboardLocaleDetection : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Locales;
    private static readonly System.IntPtr NativeFieldInfoPtr__UsePInvokes;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastKeyboardLayout;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastKeyboardLocaleName;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetForegroundWindow_Private_Static_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWindowThreadProcessId_Private_Static_UInt32_IntPtr_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyboardLayout_Private_Static_IntPtr_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyNameText_Private_Static_Int32_Int32_StringBuilder_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyboardLayoutName_Public_Static_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentKeyboardLayout_Public_Static_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyName_Public_Static_String_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentKeyboardLocale_Public_Static_KeyboardLocale_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LocalizeKeyCode_Public_Static_KeyCode_KeyCode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LocalizeKeyCode_Public_Static_KeyCode_KeyboardLocale_KeyCode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LocalizeKeyString_Public_Static_String_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742502, XrefRangeEnd = 742504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe System.IntPtr GetForegroundWindow()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KeyboardLocaleDetection.NativeMethodInfoPtr_GetForegroundWindow_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742504, XrefRangeEnd = 742506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe uint GetWindowThreadProcessId(System.IntPtr hwnd, System.IntPtr proccess)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &hwnd;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &proccess;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KeyboardLocaleDetection.NativeMethodInfoPtr_GetWindowThreadProcessId_Private_Static_UInt32_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742506, XrefRangeEnd = 742508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe System.IntPtr GetKeyboardLayout(uint thread)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &thread;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KeyboardLocaleDetection.NativeMethodInfoPtr_GetKeyboardLayout_Private_Static_IntPtr_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742508, XrefRangeEnd = 742513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static int GetKeyNameText(int lParam, [Out] StringBuilder lpString, int cchSize)
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 742550, RefRangeEnd = 742551, XrefRangeStart = 742513, XrefRangeEnd = 742550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetKeyboardLayoutName()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(KeyboardLocaleDetection.NativeMethodInfoPtr_GetKeyboardLayoutName_Public_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 742566, RefRangeEnd = 742568, XrefRangeStart = 742551, XrefRangeEnd = 742566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetCurrentKeyboardLayout()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KeyboardLocaleDetection.NativeMethodInfoPtr_GetCurrentKeyboardLayout_Public_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 742575, RefRangeEnd = 742576, XrefRangeStart = 742568, XrefRangeEnd = 742575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetKeyName(byte key)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &key;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(KeyboardLocaleDetection.NativeMethodInfoPtr_GetKeyName_Public_Static_String_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 742587, RefRangeEnd = 742590, XrefRangeStart = 742576, XrefRangeEnd = 742587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe KeyboardLocale GetCurrentKeyboardLocale()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KeyboardLocaleDetection.NativeMethodInfoPtr_GetCurrentKeyboardLocale_Public_Static_KeyboardLocale_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(KeyboardLocale*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742590, XrefRangeEnd = 742594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe KeyCode LocalizeKeyCode(KeyCode key)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &key;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KeyboardLocaleDetection.NativeMethodInfoPtr_LocalizeKeyCode_Public_Static_KeyCode_KeyCode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(KeyCode*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 742594, RefRangeEnd = 742600, XrefRangeStart = 742594, XrefRangeEnd = 742594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe KeyCode LocalizeKeyCode(KeyboardLocale locale, KeyCode key)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &locale;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &key;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KeyboardLocaleDetection.NativeMethodInfoPtr_LocalizeKeyCode_Public_Static_KeyCode_KeyboardLocale_KeyCode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(KeyCode*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742600, XrefRangeEnd = 742614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string LocalizeKeyString(string keyName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(keyName);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(KeyboardLocaleDetection.NativeMethodInfoPtr_LocalizeKeyString_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static KeyboardLocaleDetection()
    {
      Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (KeyboardLocaleDetection));
      KeyboardLocaleDetection.NativeFieldInfoPtr__Locales = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, nameof (_Locales));
      KeyboardLocaleDetection.NativeFieldInfoPtr__UsePInvokes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, nameof (_UsePInvokes));
      KeyboardLocaleDetection.NativeFieldInfoPtr__LastKeyboardLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, nameof (_LastKeyboardLayout));
      KeyboardLocaleDetection.NativeFieldInfoPtr__LastKeyboardLocaleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, nameof (_LastKeyboardLocaleName));
      KeyboardLocaleDetection.NativeMethodInfoPtr_GetForegroundWindow_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, 100665466);
      KeyboardLocaleDetection.NativeMethodInfoPtr_GetWindowThreadProcessId_Private_Static_UInt32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, 100665467);
      KeyboardLocaleDetection.NativeMethodInfoPtr_GetKeyboardLayout_Private_Static_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, 100665468);
      KeyboardLocaleDetection.NativeMethodInfoPtr_GetKeyNameText_Private_Static_Int32_Int32_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, 100665469);
      KeyboardLocaleDetection.NativeMethodInfoPtr_GetKeyboardLayoutName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, 100665470);
      KeyboardLocaleDetection.NativeMethodInfoPtr_GetCurrentKeyboardLayout_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, 100665471);
      KeyboardLocaleDetection.NativeMethodInfoPtr_GetKeyName_Public_Static_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, 100665472);
      KeyboardLocaleDetection.NativeMethodInfoPtr_GetCurrentKeyboardLocale_Public_Static_KeyboardLocale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, 100665473);
      KeyboardLocaleDetection.NativeMethodInfoPtr_LocalizeKeyCode_Public_Static_KeyCode_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, 100665474);
      KeyboardLocaleDetection.NativeMethodInfoPtr_LocalizeKeyCode_Public_Static_KeyCode_KeyboardLocale_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, 100665475);
      KeyboardLocaleDetection.NativeMethodInfoPtr_LocalizeKeyString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardLocaleDetection>.NativeClassPtr, 100665476);
    }

    public KeyboardLocaleDetection(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Dictionary<int, string> _Locales
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(KeyboardLocaleDetection.NativeFieldInfoPtr__Locales, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<int, string>) null : new Dictionary<int, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KeyboardLocaleDetection.NativeFieldInfoPtr__Locales, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe bool _UsePInvokes
    {
      get
      {
        bool usePinvokes;
        IL2CPP.il2cpp_field_static_get_value(KeyboardLocaleDetection.NativeFieldInfoPtr__UsePInvokes, (void*) &usePinvokes);
        return usePinvokes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KeyboardLocaleDetection.NativeFieldInfoPtr__UsePInvokes, (void*) &value);
      }
    }

    public static unsafe int _LastKeyboardLayout
    {
      get
      {
        int lastKeyboardLayout;
        IL2CPP.il2cpp_field_static_get_value(KeyboardLocaleDetection.NativeFieldInfoPtr__LastKeyboardLayout, (void*) &lastKeyboardLayout);
        return lastKeyboardLayout;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KeyboardLocaleDetection.NativeFieldInfoPtr__LastKeyboardLayout, (void*) &value);
      }
    }

    public static unsafe string _LastKeyboardLocaleName
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(KeyboardLocaleDetection.NativeFieldInfoPtr__LastKeyboardLocaleName, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KeyboardLocaleDetection.NativeFieldInfoPtr__LastKeyboardLocaleName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
