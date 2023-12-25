// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.AchievementSubTaskEntryData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AchievementSubTaskEntryData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredCompletedCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Div100;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PrefabGUID_LocalizationKey_Int32_Boolean_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public LocalizationKey Text;
    [FieldOffset(20)]
    public int RequiredCompletedCount;
    [FieldOffset(24)]
    public bool Div100;

    [CallerCount(0)]
    public unsafe AchievementSubTaskEntryData(
      PrefabGUID prefabGuid,
      LocalizationKey text,
      int requiredCompletedCount,
      bool divideVisualsBy100)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &text;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &requiredCompletedCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &divideVisualsBy100;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementSubTaskEntryData.NativeMethodInfoPtr__ctor_Public_Void_PrefabGUID_LocalizationKey_Int32_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AchievementSubTaskEntryData()
    {
      Il2CppClassPointerStore<AchievementSubTaskEntryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (AchievementSubTaskEntryData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementSubTaskEntryData>.NativeClassPtr);
      AchievementSubTaskEntryData.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskEntryData>.NativeClassPtr, nameof (PrefabGuid));
      AchievementSubTaskEntryData.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskEntryData>.NativeClassPtr, nameof (Text));
      AchievementSubTaskEntryData.NativeFieldInfoPtr_RequiredCompletedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskEntryData>.NativeClassPtr, nameof (RequiredCompletedCount));
      AchievementSubTaskEntryData.NativeFieldInfoPtr_Div100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskEntryData>.NativeClassPtr, nameof (Div100));
      AchievementSubTaskEntryData.NativeMethodInfoPtr__ctor_Public_Void_PrefabGUID_LocalizationKey_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementSubTaskEntryData>.NativeClassPtr, 100692253);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AchievementSubTaskEntryData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
