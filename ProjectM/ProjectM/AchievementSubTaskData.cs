// Decompiled with JetBrains decompiler
// Type: ProjectM.AchievementSubTaskData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AchievementSubTaskData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_TaskTitle;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_TechReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredCompletedCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressLinkType;
    [FieldOffset(0)]
    public EntityCategory EntityCategory;
    [FieldOffset(8)]
    public LocalizationKey TaskTitle;
    [FieldOffset(24)]
    public PrefabGUID PrefabReference;
    [FieldOffset(28)]
    public PrefabGUID TechReference;
    [FieldOffset(32)]
    public int RequiredCompletedCount;
    [FieldOffset(40)]
    public BlobAssetReference<ConditionBlob> Condition;
    [FieldOffset(48)]
    public AchievementProgressType ProgressType;
    [FieldOffset(49)]
    public AchievementProgressLinkType ProgressLinkType;

    static AchievementSubTaskData()
    {
      Il2CppClassPointerStore<AchievementSubTaskData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AchievementSubTaskData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementSubTaskData>.NativeClassPtr);
      AchievementSubTaskData.NativeFieldInfoPtr_EntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskData>.NativeClassPtr, nameof (EntityCategory));
      AchievementSubTaskData.NativeFieldInfoPtr_TaskTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskData>.NativeClassPtr, nameof (TaskTitle));
      AchievementSubTaskData.NativeFieldInfoPtr_PrefabReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskData>.NativeClassPtr, nameof (PrefabReference));
      AchievementSubTaskData.NativeFieldInfoPtr_TechReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskData>.NativeClassPtr, nameof (TechReference));
      AchievementSubTaskData.NativeFieldInfoPtr_RequiredCompletedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskData>.NativeClassPtr, nameof (RequiredCompletedCount));
      AchievementSubTaskData.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskData>.NativeClassPtr, nameof (Condition));
      AchievementSubTaskData.NativeFieldInfoPtr_ProgressType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskData>.NativeClassPtr, nameof (ProgressType));
      AchievementSubTaskData.NativeFieldInfoPtr_ProgressLinkType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskData>.NativeClassPtr, nameof (ProgressLinkType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AchievementSubTaskData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
