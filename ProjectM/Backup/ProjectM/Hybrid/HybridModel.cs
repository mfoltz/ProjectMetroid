// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModel
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Hybrid
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HybridModel
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModelIndex;
    [FieldOffset(0)]
    public Entity GameplayEntity;
    [FieldOffset(8)]
    public int ModelIndex;

    static HybridModel()
    {
      Il2CppClassPointerStore<HybridModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridModel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModel>.NativeClassPtr);
      HybridModel.NativeFieldInfoPtr_GameplayEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModel>.NativeClassPtr, nameof (GameplayEntity));
      HybridModel.NativeFieldInfoPtr_ModelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModel>.NativeClassPtr, nameof (ModelIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModel>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
