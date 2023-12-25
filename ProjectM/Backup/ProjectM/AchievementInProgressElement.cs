// Decompiled with JetBrains decompiler
// Type: ProjectM.AchievementInProgressElement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AchievementInProgressElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AchievementPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompletedAmount;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInProgress_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNotInProgress_Public_get_Boolean_0;
    [FieldOffset(0)]
    public PrefabGUID AchievementPrefabGuid;
    [FieldOffset(4)]
    public int CompletedAmount;

    public unsafe bool IsInProgress
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 996448, RefRangeEnd = 996452, XrefRangeStart = 996446, XrefRangeEnd = 996448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementInProgressElement.NativeMethodInfoPtr_get_IsInProgress_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsNotInProgress
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 747822, RefRangeEnd = 747831, XrefRangeStart = 747822, XrefRangeEnd = 747831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementInProgressElement.NativeMethodInfoPtr_get_IsNotInProgress_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static AchievementInProgressElement()
    {
      Il2CppClassPointerStore<AchievementInProgressElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AchievementInProgressElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementInProgressElement>.NativeClassPtr);
      AchievementInProgressElement.NativeFieldInfoPtr_AchievementPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementInProgressElement>.NativeClassPtr, nameof (AchievementPrefabGuid));
      AchievementInProgressElement.NativeFieldInfoPtr_CompletedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementInProgressElement>.NativeClassPtr, nameof (CompletedAmount));
      AchievementInProgressElement.NativeMethodInfoPtr_get_IsInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementInProgressElement>.NativeClassPtr, 100677021);
      AchievementInProgressElement.NativeMethodInfoPtr_get_IsNotInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementInProgressElement>.NativeClassPtr, 100677022);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AchievementInProgressElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
