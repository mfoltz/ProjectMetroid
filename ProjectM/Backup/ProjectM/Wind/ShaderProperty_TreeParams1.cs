// Decompiled with JetBrains decompiler
// Type: ProjectM.Wind.ShaderProperty_TreeParams1
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Wind
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ShaderProperty_TreeParams1
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TreeParams1;
    [FieldOffset(0)]
    public float4 TreeParams1;

    static ShaderProperty_TreeParams1()
    {
      Il2CppClassPointerStore<ShaderProperty_TreeParams1>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Wind", nameof (ShaderProperty_TreeParams1));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperty_TreeParams1>.NativeClassPtr);
      ShaderProperty_TreeParams1.NativeFieldInfoPtr_TreeParams1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty_TreeParams1>.NativeClassPtr, nameof (TreeParams1));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderProperty_TreeParams1>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
