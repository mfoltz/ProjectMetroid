// Decompiled with JetBrains decompiler
// Type: ProjectM.Wind.ShaderProperty_TreeParams0
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
  public struct ShaderProperty_TreeParams0
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TreeParams0;
    [FieldOffset(0)]
    public float4 TreeParams0;

    static ShaderProperty_TreeParams0()
    {
      Il2CppClassPointerStore<ShaderProperty_TreeParams0>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Wind", nameof (ShaderProperty_TreeParams0));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperty_TreeParams0>.NativeClassPtr);
      ShaderProperty_TreeParams0.NativeFieldInfoPtr_TreeParams0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty_TreeParams0>.NativeClassPtr, nameof (TreeParams0));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderProperty_TreeParams0>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
