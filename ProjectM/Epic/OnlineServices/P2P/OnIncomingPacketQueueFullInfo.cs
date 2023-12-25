// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.OnIncomingPacketQueueFullInfo
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P
{
  public sealed class OnIncomingPacketQueueFullInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientData_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PacketQueueMaxSizeBytes_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PacketQueueCurrentSizeBytes_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OverflowPacketLocalUserId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OverflowPacketChannel_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OverflowPacketSizeBytes_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PacketQueueMaxSizeBytes_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PacketQueueCurrentSizeBytes_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OverflowPacketLocalUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OverflowPacketLocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OverflowPacketChannel_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OverflowPacketChannel_Public_set_Void_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OverflowPacketSizeBytes_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OverflowPacketSizeBytes_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_Unboxed_1_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_OnIncomingPacketQueueFullInfoInternal_0;

    public virtual unsafe Il2CppSystem.Object ClientData
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong PacketQueueMaxSizeBytes
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_PacketQueueMaxSizeBytes_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_PacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong PacketQueueCurrentSizeBytes
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_PacketQueueCurrentSizeBytes_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_PacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId OverflowPacketLocalUserId
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_OverflowPacketLocalUserId_Public_get_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_OverflowPacketLocalUserId_Public_set_Void_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe byte OverflowPacketChannel
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_OverflowPacketChannel_Public_get_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_OverflowPacketChannel_Public_set_Void_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint OverflowPacketSizeBytes
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_OverflowPacketSizeBytes_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_OverflowPacketSizeBytes_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Nullable_Unboxed<Result> GetResultCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_Unboxed_1_Result_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<Result>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 951413, RefRangeEnd = 951414, XrefRangeStart = 951406, XrefRangeEnd = 951413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref OnIncomingPacketQueueFullInfoInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_OnIncomingPacketQueueFullInfoInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OnIncomingPacketQueueFullInfo()
    {
      Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (OnIncomingPacketQueueFullInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr);
      OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__ClientData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, "<ClientData>k__BackingField");
      OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__PacketQueueMaxSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, "<PacketQueueMaxSizeBytes>k__BackingField");
      OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__PacketQueueCurrentSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, "<PacketQueueCurrentSizeBytes>k__BackingField");
      OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketLocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, "<OverflowPacketLocalUserId>k__BackingField");
      OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketChannel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, "<OverflowPacketChannel>k__BackingField");
      OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, "<OverflowPacketSizeBytes>k__BackingField");
      OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668969);
      OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668970);
      OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_PacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668971);
      OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_PacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668972);
      OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_PacketQueueCurrentSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668973);
      OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_PacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668974);
      OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_OverflowPacketLocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668975);
      OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_OverflowPacketLocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668976);
      OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_OverflowPacketChannel_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668977);
      OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_OverflowPacketChannel_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668978);
      OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_OverflowPacketSizeBytes_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668979);
      OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_OverflowPacketSizeBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668980);
      OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_Unboxed_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668981);
      OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_OnIncomingPacketQueueFullInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668982);
    }

    public OnIncomingPacketQueueFullInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public OnIncomingPacketQueueFullInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, data));
    }

    public unsafe Il2CppSystem.Object _ClientData_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__ClientData_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__ClientData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ulong _PacketQueueMaxSizeBytes_k__BackingField
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__PacketQueueMaxSizeBytes_k__BackingField));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__PacketQueueMaxSizeBytes_k__BackingField)) = value;
      }
    }

    public unsafe ulong _PacketQueueCurrentSizeBytes_k__BackingField
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__PacketQueueCurrentSizeBytes_k__BackingField));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__PacketQueueCurrentSizeBytes_k__BackingField)) = value;
      }
    }

    public unsafe ProductUserId _OverflowPacketLocalUserId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketLocalUserId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketLocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe byte _OverflowPacketChannel_k__BackingField
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketChannel_k__BackingField));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketChannel_k__BackingField)) = value;
      }
    }

    public unsafe uint _OverflowPacketSizeBytes_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketSizeBytes_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketSizeBytes_k__BackingField)) = value;
      }
    }
  }
}
