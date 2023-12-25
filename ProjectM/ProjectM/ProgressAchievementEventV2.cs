// Decompiled with JetBrains decompiler
// Type: ProjectM.ProgressAchievementEventV2
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ProgressAchievementEventV2
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_User;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressSetType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressAmount;
    [FieldOffset(0)]
    public PrefabGUID PrefabReference;
    [FieldOffset(4)]
    public Entity User;
    [FieldOffset(12)]
    public Entity Target;
    [FieldOffset(20)]
    public AchievementProgressType ProgressType;
    [FieldOffset(21)]
    public AchievementProgressSetType ProgressSetType;
    [FieldOffset(24)]
    public int ProgressAmount;

    static ProgressAchievementEventV2()
    {
      Il2CppClassPointerStore<ProgressAchievementEventV2>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProgressAchievementEventV2));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressAchievementEventV2>.NativeClassPtr);
      ProgressAchievementEventV2.NativeFieldInfoPtr_PrefabReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressAchievementEventV2>.NativeClassPtr, nameof (PrefabReference));
      ProgressAchievementEventV2.NativeFieldInfoPtr_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressAchievementEventV2>.NativeClassPtr, nameof (User));
      ProgressAchievementEventV2.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressAchievementEventV2>.NativeClassPtr, nameof (Target));
      ProgressAchievementEventV2.NativeFieldInfoPtr_ProgressType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressAchievementEventV2>.NativeClassPtr, nameof (ProgressType));
      ProgressAchievementEventV2.NativeFieldInfoPtr_ProgressSetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressAchievementEventV2>.NativeClassPtr, nameof (ProgressSetType));
      ProgressAchievementEventV2.NativeFieldInfoPtr_ProgressAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressAchievementEventV2>.NativeClassPtr, nameof (ProgressAmount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProgressAchievementEventV2>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
