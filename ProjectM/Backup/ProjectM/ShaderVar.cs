// Decompiled with JetBrains decompiler
// Type: ProjectM.ShaderVar
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM
{
  public sealed class ShaderVar : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Shader;
    private static readonly System.IntPtr NativeFieldInfoPtr_PassType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Keywords;

    static ShaderVar()
    {
      Il2CppClassPointerStore<ShaderVar>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ShaderVar));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderVar>.NativeClassPtr);
      ShaderVar.NativeFieldInfoPtr_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVar>.NativeClassPtr, nameof (Shader));
      ShaderVar.NativeFieldInfoPtr_PassType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVar>.NativeClassPtr, nameof (PassType));
      ShaderVar.NativeFieldInfoPtr_Keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVar>.NativeClassPtr, nameof (Keywords));
    }

    public ShaderVar(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ShaderVar()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShaderVar>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderVar>.NativeClassPtr, data));
    }

    public unsafe Shader Shader
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderVar.NativeFieldInfoPtr_Shader));
        return pointer == System.IntPtr.Zero ? (Shader) null : new Shader(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShaderVar.NativeFieldInfoPtr_Shader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PassType PassType
    {
      get
      {
        return *(PassType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderVar.NativeFieldInfoPtr_PassType));
      }
      [param: In] set
      {
        *(PassType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderVar.NativeFieldInfoPtr_PassType)) = value;
      }
    }

    public unsafe Il2CppStringArray Keywords
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderVar.NativeFieldInfoPtr_Keywords));
        return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShaderVar.NativeFieldInfoPtr_Keywords), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
