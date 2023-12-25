// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sanctions.SanctionsInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sanctions
{
  public sealed class SanctionsInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyplayersanctionbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetplayersanctioncountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayersanctionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryactiveplayersanctionsApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyPlayerSanctionByIndex_Public_Result_byref_CopyPlayerSanctionByIndexOptions_byref_Nullable_1_PlayerSanction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerSanctionCount_Public_UInt32_byref_GetPlayerSanctionCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryActivePlayerSanctions_Public_Void_byref_QueryActivePlayerSanctionsOptions_Object_OnQueryActivePlayerSanctionsCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryActivePlayerSanctionsCallbackInternalImplementation_Internal_Static_Void_byref_QueryActivePlayerSanctionsCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SanctionsInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SanctionsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943485, XrefRangeEnd = 943499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyPlayerSanctionByIndex(
      ref CopyPlayerSanctionByIndexOptions options,
      out Il2CppSystem.Nullable<PlayerSanction> outSanction)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SanctionsInterface.NativeMethodInfoPtr_CopyPlayerSanctionByIndex_Public_Result_byref_CopyPlayerSanctionByIndexOptions_byref_Nullable_1_PlayerSanction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<PlayerSanction> local = ref outSanction;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<PlayerSanction>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943499, XrefRangeEnd = 943507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetPlayerSanctionCount(ref GetPlayerSanctionCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SanctionsInterface.NativeMethodInfoPtr_GetPlayerSanctionCount_Public_UInt32_byref_GetPlayerSanctionCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943507, XrefRangeEnd = 943526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryActivePlayerSanctions(
      ref QueryActivePlayerSanctionsOptions options,
      Il2CppSystem.Object clientData,
      OnQueryActivePlayerSanctionsCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SanctionsInterface.NativeMethodInfoPtr_QueryActivePlayerSanctions_Public_Void_byref_QueryActivePlayerSanctionsOptions_Object_OnQueryActivePlayerSanctionsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943526, XrefRangeEnd = 943533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryActivePlayerSanctionsCallbackInternalImplementation(
      ref QueryActivePlayerSanctionsCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SanctionsInterface.NativeMethodInfoPtr_OnQueryActivePlayerSanctionsCallbackInternalImplementation_Internal_Static_Void_byref_QueryActivePlayerSanctionsCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SanctionsInterface()
    {
      Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sanctions", nameof (SanctionsInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr);
      SanctionsInterface.NativeFieldInfoPtr_CopyplayersanctionbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, nameof (CopyplayersanctionbyindexApiLatest));
      SanctionsInterface.NativeFieldInfoPtr_GetplayersanctioncountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, nameof (GetplayersanctioncountApiLatest));
      SanctionsInterface.NativeFieldInfoPtr_PlayersanctionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, nameof (PlayersanctionApiLatest));
      SanctionsInterface.NativeFieldInfoPtr_QueryactiveplayersanctionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, nameof (QueryactiveplayersanctionsApiLatest));
      SanctionsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, 100666814);
      SanctionsInterface.NativeMethodInfoPtr_CopyPlayerSanctionByIndex_Public_Result_byref_CopyPlayerSanctionByIndexOptions_byref_Nullable_1_PlayerSanction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, 100666816);
      SanctionsInterface.NativeMethodInfoPtr_GetPlayerSanctionCount_Public_UInt32_byref_GetPlayerSanctionCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, 100666817);
      SanctionsInterface.NativeMethodInfoPtr_QueryActivePlayerSanctions_Public_Void_byref_QueryActivePlayerSanctionsOptions_Object_OnQueryActivePlayerSanctionsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, 100666818);
      SanctionsInterface.NativeMethodInfoPtr_OnQueryActivePlayerSanctionsCallbackInternalImplementation_Internal_Static_Void_byref_QueryActivePlayerSanctionsCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, 100666819);
    }

    public SanctionsInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int CopyplayersanctionbyindexApiLatest
    {
      get
      {
        int copyplayersanctionbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SanctionsInterface.NativeFieldInfoPtr_CopyplayersanctionbyindexApiLatest, (void*) &copyplayersanctionbyindexApiLatest);
        return copyplayersanctionbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SanctionsInterface.NativeFieldInfoPtr_CopyplayersanctionbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetplayersanctioncountApiLatest
    {
      get
      {
        int getplayersanctioncountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SanctionsInterface.NativeFieldInfoPtr_GetplayersanctioncountApiLatest, (void*) &getplayersanctioncountApiLatest);
        return getplayersanctioncountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SanctionsInterface.NativeFieldInfoPtr_GetplayersanctioncountApiLatest, (void*) &value);
      }
    }

    public static unsafe int PlayersanctionApiLatest
    {
      get
      {
        int playersanctionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SanctionsInterface.NativeFieldInfoPtr_PlayersanctionApiLatest, (void*) &playersanctionApiLatest);
        return playersanctionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SanctionsInterface.NativeFieldInfoPtr_PlayersanctionApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryactiveplayersanctionsApiLatest
    {
      get
      {
        int queryactiveplayersanctionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SanctionsInterface.NativeFieldInfoPtr_QueryactiveplayersanctionsApiLatest, (void*) &queryactiveplayersanctionsApiLatest);
        return queryactiveplayersanctionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SanctionsInterface.NativeFieldInfoPtr_QueryactiveplayersanctionsApiLatest, (void*) &value);
      }
    }
  }
}
