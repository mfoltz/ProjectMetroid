﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.CopyLeaderboardDefinitionByLeaderboardIdOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Leaderboards
{
  public sealed class CopyLeaderboardDefinitionByLeaderboardIdOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__LeaderboardId_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LeaderboardId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_Utf8String_0;

    public unsafe Epic.OnlineServices.Utf8String LeaderboardId
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardDefinitionByLeaderboardIdOptions.NativeMethodInfoPtr_get_LeaderboardId_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardDefinitionByLeaderboardIdOptions.NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static CopyLeaderboardDefinitionByLeaderboardIdOptions()
    {
      Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Leaderboards", nameof (CopyLeaderboardDefinitionByLeaderboardIdOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptions>.NativeClassPtr);
      CopyLeaderboardDefinitionByLeaderboardIdOptions.NativeFieldInfoPtr__LeaderboardId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptions>.NativeClassPtr, "<LeaderboardId>k__BackingField");
      CopyLeaderboardDefinitionByLeaderboardIdOptions.NativeMethodInfoPtr_get_LeaderboardId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptions>.NativeClassPtr, 100670866);
      CopyLeaderboardDefinitionByLeaderboardIdOptions.NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptions>.NativeClassPtr, 100670867);
    }

    public CopyLeaderboardDefinitionByLeaderboardIdOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public CopyLeaderboardDefinitionByLeaderboardIdOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptions>.NativeClassPtr, data));
    }

    public unsafe Epic.OnlineServices.Utf8String _LeaderboardId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyLeaderboardDefinitionByLeaderboardIdOptions.NativeFieldInfoPtr__LeaderboardId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CopyLeaderboardDefinitionByLeaderboardIdOptions.NativeFieldInfoPtr__LeaderboardId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
