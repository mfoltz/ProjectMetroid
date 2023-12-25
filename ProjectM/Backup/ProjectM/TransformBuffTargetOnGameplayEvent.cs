// Decompiled with JetBrains decompiler
// Type: ProjectM.TransformBuffTargetOnGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TransformBuffTargetOnGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeepHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreDefaultSpawnBuff;
    [FieldOffset(0)]
    public PrefabGUID Prefab;
    [FieldOffset(4)]
    public bool KeepHealth;
    [FieldOffset(5)]
    public bool IgnoreDefaultSpawnBuff;

    static TransformBuffTargetOnGameplayEvent()
    {
      Il2CppClassPointerStore<TransformBuffTargetOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TransformBuffTargetOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformBuffTargetOnGameplayEvent>.NativeClassPtr);
      TransformBuffTargetOnGameplayEvent.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformBuffTargetOnGameplayEvent>.NativeClassPtr, nameof (Prefab));
      TransformBuffTargetOnGameplayEvent.NativeFieldInfoPtr_KeepHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformBuffTargetOnGameplayEvent>.NativeClassPtr, nameof (KeepHealth));
      TransformBuffTargetOnGameplayEvent.NativeFieldInfoPtr_IgnoreDefaultSpawnBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformBuffTargetOnGameplayEvent>.NativeClassPtr, nameof (IgnoreDefaultSpawnBuff));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformBuffTargetOnGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
