// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.CopyLeaderboardUserScoreByIndexOptions
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
  public sealed class CopyLeaderboardUserScoreByIndexOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__LeaderboardUserScoreIndex_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__StatName_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LeaderboardUserScoreIndex_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LeaderboardUserScoreIndex_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StatName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StatName_Public_set_Void_Utf8String_0;

    public unsafe uint LeaderboardUserScoreIndex
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardUserScoreByIndexOptions.NativeMethodInfoPtr_get_LeaderboardUserScoreIndex_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardUserScoreByIndexOptions.NativeMethodInfoPtr_set_LeaderboardUserScoreIndex_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String StatName
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardUserScoreByIndexOptions.NativeMethodInfoPtr_get_StatName_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardUserScoreByIndexOptions.NativeMethodInfoPtr_set_StatName_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static CopyLeaderboardUserScoreByIndexOptions()
    {
      Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Leaderboards", nameof (CopyLeaderboardUserScoreByIndexOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptions>.NativeClassPtr);
      CopyLeaderboardUserScoreByIndexOptions.NativeFieldInfoPtr__LeaderboardUserScoreIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptions>.NativeClassPtr, "<LeaderboardUserScoreIndex>k__BackingField");
      CopyLeaderboardUserScoreByIndexOptions.NativeFieldInfoPtr__StatName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptions>.NativeClassPtr, "<StatName>k__BackingField");
      CopyLeaderboardUserScoreByIndexOptions.NativeMethodInfoPtr_get_LeaderboardUserScoreIndex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptions>.NativeClassPtr, 100670884);
      CopyLeaderboardUserScoreByIndexOptions.NativeMethodInfoPtr_set_LeaderboardUserScoreIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptions>.NativeClassPtr, 100670885);
      CopyLeaderboardUserScoreByIndexOptions.NativeMethodInfoPtr_get_StatName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptions>.NativeClassPtr, 100670886);
      CopyLeaderboardUserScoreByIndexOptions.NativeMethodInfoPtr_set_StatName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptions>.NativeClassPtr, 100670887);
    }

    public CopyLeaderboardUserScoreByIndexOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public CopyLeaderboardUserScoreByIndexOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptions>.NativeClassPtr, data));
    }

    public unsafe uint _LeaderboardUserScoreIndex_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyLeaderboardUserScoreByIndexOptions.NativeFieldInfoPtr__LeaderboardUserScoreIndex_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyLeaderboardUserScoreByIndexOptions.NativeFieldInfoPtr__LeaderboardUserScoreIndex_k__BackingField)) = value;
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _StatName_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyLeaderboardUserScoreByIndexOptions.NativeFieldInfoPtr__StatName_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CopyLeaderboardUserScoreByIndexOptions.NativeFieldInfoPtr__StatName_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
