﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.CopyAchievementDefinitionByIndexOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CopyAchievementDefinitionByIndexOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__AchievementIndex_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AchievementIndex_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementIndex_Public_set_Void_UInt32_0;
    [FieldOffset(0)]
    public uint _AchievementIndex_k__BackingField;

    public unsafe uint AchievementIndex
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CopyAchievementDefinitionByIndexOptions.NativeMethodInfoPtr_get_AchievementIndex_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopyAchievementDefinitionByIndexOptions.NativeMethodInfoPtr_set_AchievementIndex_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static CopyAchievementDefinitionByIndexOptions()
    {
      Il2CppClassPointerStore<CopyAchievementDefinitionByIndexOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Achievements", nameof (CopyAchievementDefinitionByIndexOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyAchievementDefinitionByIndexOptions>.NativeClassPtr);
      CopyAchievementDefinitionByIndexOptions.NativeFieldInfoPtr__AchievementIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyAchievementDefinitionByIndexOptions>.NativeClassPtr, "<AchievementIndex>k__BackingField");
      CopyAchievementDefinitionByIndexOptions.NativeMethodInfoPtr_get_AchievementIndex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyAchievementDefinitionByIndexOptions>.NativeClassPtr, 100674868);
      CopyAchievementDefinitionByIndexOptions.NativeMethodInfoPtr_set_AchievementIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyAchievementDefinitionByIndexOptions>.NativeClassPtr, 100674869);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyAchievementDefinitionByIndexOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
