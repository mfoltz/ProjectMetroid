// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.CastleDyePropertyIDs
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public static class CastleDyePropertyIDs : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UDIMShader2;
    private static readonly System.IntPtr NativeFieldInfoPtr_UDIMShader3;
    private static readonly System.IntPtr NativeFieldInfoPtr_Udim2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Udim3;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorTrim1;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorTrim2;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorTrim3;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorTintTrim1;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorTintTrim2;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorTintTrim3;

    static CastleDyePropertyIDs()
    {
      Il2CppClassPointerStore<CastleDyePropertyIDs>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (CastleDyePropertyIDs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleDyePropertyIDs>.NativeClassPtr);
      CastleDyePropertyIDs.NativeFieldInfoPtr_UDIMShader2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDyePropertyIDs>.NativeClassPtr, nameof (UDIMShader2));
      CastleDyePropertyIDs.NativeFieldInfoPtr_UDIMShader3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDyePropertyIDs>.NativeClassPtr, nameof (UDIMShader3));
      CastleDyePropertyIDs.NativeFieldInfoPtr_Udim2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDyePropertyIDs>.NativeClassPtr, nameof (Udim2));
      CastleDyePropertyIDs.NativeFieldInfoPtr_Udim3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDyePropertyIDs>.NativeClassPtr, nameof (Udim3));
      CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDyePropertyIDs>.NativeClassPtr, nameof (BaseColor));
      CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTrim1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDyePropertyIDs>.NativeClassPtr, nameof (BaseColorTrim1));
      CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTrim2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDyePropertyIDs>.NativeClassPtr, nameof (BaseColorTrim2));
      CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTrim3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDyePropertyIDs>.NativeClassPtr, nameof (BaseColorTrim3));
      CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTintTrim1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDyePropertyIDs>.NativeClassPtr, nameof (BaseColorTintTrim1));
      CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTintTrim2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDyePropertyIDs>.NativeClassPtr, nameof (BaseColorTintTrim2));
      CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTintTrim3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDyePropertyIDs>.NativeClassPtr, nameof (BaseColorTintTrim3));
    }

    public CastleDyePropertyIDs(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string UDIMShader2
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(CastleDyePropertyIDs.NativeFieldInfoPtr_UDIMShader2, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CastleDyePropertyIDs.NativeFieldInfoPtr_UDIMShader2, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string UDIMShader3
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(CastleDyePropertyIDs.NativeFieldInfoPtr_UDIMShader3, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CastleDyePropertyIDs.NativeFieldInfoPtr_UDIMShader3, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe Shader Udim2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CastleDyePropertyIDs.NativeFieldInfoPtr_Udim2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Shader) null : new Shader(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CastleDyePropertyIDs.NativeFieldInfoPtr_Udim2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Shader Udim3
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CastleDyePropertyIDs.NativeFieldInfoPtr_Udim3, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Shader) null : new Shader(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CastleDyePropertyIDs.NativeFieldInfoPtr_Udim3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int BaseColor
    {
      get
      {
        int baseColor;
        IL2CPP.il2cpp_field_static_get_value(CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColor, (void*) &baseColor);
        return baseColor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColor, (void*) &value);
      }
    }

    public static unsafe int BaseColorTrim1
    {
      get
      {
        int baseColorTrim1;
        IL2CPP.il2cpp_field_static_get_value(CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTrim1, (void*) &baseColorTrim1);
        return baseColorTrim1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTrim1, (void*) &value);
      }
    }

    public static unsafe int BaseColorTrim2
    {
      get
      {
        int baseColorTrim2;
        IL2CPP.il2cpp_field_static_get_value(CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTrim2, (void*) &baseColorTrim2);
        return baseColorTrim2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTrim2, (void*) &value);
      }
    }

    public static unsafe int BaseColorTrim3
    {
      get
      {
        int baseColorTrim3;
        IL2CPP.il2cpp_field_static_get_value(CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTrim3, (void*) &baseColorTrim3);
        return baseColorTrim3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTrim3, (void*) &value);
      }
    }

    public static unsafe int BaseColorTintTrim1
    {
      get
      {
        int baseColorTintTrim1;
        IL2CPP.il2cpp_field_static_get_value(CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTintTrim1, (void*) &baseColorTintTrim1);
        return baseColorTintTrim1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTintTrim1, (void*) &value);
      }
    }

    public static unsafe int BaseColorTintTrim2
    {
      get
      {
        int baseColorTintTrim2;
        IL2CPP.il2cpp_field_static_get_value(CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTintTrim2, (void*) &baseColorTintTrim2);
        return baseColorTintTrim2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTintTrim2, (void*) &value);
      }
    }

    public static unsafe int BaseColorTintTrim3
    {
      get
      {
        int baseColorTintTrim3;
        IL2CPP.il2cpp_field_static_get_value(CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTintTrim3, (void*) &baseColorTintTrim3);
        return baseColorTintTrim3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CastleDyePropertyIDs.NativeFieldInfoPtr_BaseColorTintTrim3, (void*) &value);
      }
    }
  }
}
