// Decompiled with JetBrains decompiler
// Type: ProjectM.EOS.SessionData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices;
using Epic.OnlineServices.Platform;
using Epic.OnlineServices.Sessions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.EOS
{
  public sealed class SessionData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LogHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr__HostAddress_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaxPlayers_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__SessionAttributes_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HostAddress_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HostAddress_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxPlayers_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxPlayers_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BucketId_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowJoinInProgress_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PermissionLevel_Public_get_OnlineSessionPermissionLevel_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SessionAttributes_Public_get_Dictionary_2_String_KeyValuePair_2_AttributeDataValue_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionAttributes_Private_set_Void_Dictionary_2_String_KeyValuePair_2_AttributeDataValue_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SessionData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAttribute_Public_Void_SessionAttribute_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnsetAttribute_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAttribute_Public_Boolean_String_byref_AttributeDataValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAttributeOfType_Public_Boolean_String_AttributeType_byref_AttributeDataValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_SessionData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_String_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SessionData_SessionData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SessionData_SessionData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToCreateSessionModificationOptions_Public_CreateSessionModificationOptions_PlatformInterface_String_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToSessionModificationSetJoinInProgressAllowedOptions_Public_SessionModificationSetJoinInProgressAllowedOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToSessionModificationSetInvitesAllowedOptions_Public_SessionModificationSetInvitesAllowedOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToSessionModificationSetPermissionLevelOptions_Public_SessionModificationSetPermissionLevelOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToSessionModificationSetHostAddressOptions_Public_SessionModificationSetHostAddressOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToSessionModificationSetMaxPlayersOptions_Public_SessionModificationSetMaxPlayersOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToSessionModificationSetBucketIdOptions_Public_SessionModificationSetBucketIdOptions_0;

    public unsafe string HostAddress
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_get_HostAddress_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_set_HostAddress_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint MaxPlayers
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_get_MaxPlayers_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(11), CachedScanResults(RefRangeStart = 204781, RefRangeEnd = 204792, XrefRangeStart = 204781, XrefRangeEnd = 204792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_set_MaxPlayers_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string BucketId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123032, XrefRangeEnd = 1123034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_get_BucketId_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe bool AllowJoinInProgress
    {
      [CallerCount(25), CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_get_AllowJoinInProgress_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool InvitesAllowed
    {
      [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe OnlineSessionPermissionLevel PermissionLevel
    {
      [CallerCount(1474), CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_get_PermissionLevel_Public_get_OnlineSessionPermissionLevel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(OnlineSessionPermissionLevel*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Dictionary<string, KeyValuePair<AttributeDataValue, bool>> SessionAttributes
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_get_SessionAttributes_Public_get_Dictionary_2_String_KeyValuePair_2_AttributeDataValue_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<string, KeyValuePair<AttributeDataValue, bool>>) null : new Dictionary<string, KeyValuePair<AttributeDataValue, bool>>(pointer);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_set_SessionAttributes_Private_set_Void_Dictionary_2_String_KeyValuePair_2_AttributeDataValue_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123034, XrefRangeEnd = 1123043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionData(SessionData original)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) original));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr__ctor_Public_Void_SessionData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1123051, RefRangeEnd = 1123052, XrefRangeStart = 1123043, XrefRangeEnd = 1123051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionData(string hostAddress, uint maxPlayers)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(hostAddress);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxPlayers;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr__ctor_Public_Void_String_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 1123059, RefRangeEnd = 1123087, XrefRangeStart = 1123052, XrefRangeEnd = 1123059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAttribute(SessionAttribute attribute, bool isPublic = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) attribute));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isPublic;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_SetAttribute_Public_Void_SessionAttribute_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123087, XrefRangeEnd = 1123101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnsetAttribute(string attributeKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(attributeKey);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_UnsetAttribute_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1123107, RefRangeEnd = 1123109, XrefRangeStart = 1123101, XrefRangeEnd = 1123107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetAttribute(string key, out AttributeDataValue value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(key);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_TryGetAttribute_Public_Boolean_String_byref_AttributeDataValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref AttributeDataValue local = ref value;
      System.IntPtr pointer = zero;
      AttributeDataValue attributeDataValue = pointer == System.IntPtr.Zero ? (AttributeDataValue) null : new AttributeDataValue(pointer);
      local = attributeDataValue;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1123110, RefRangeEnd = 1123116, XrefRangeStart = 1123109, XrefRangeEnd = 1123110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetAttributeOfType(
      string key,
      AttributeType type,
      out AttributeDataValue value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(key);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_TryGetAttributeOfType_Public_Boolean_String_AttributeType_byref_AttributeDataValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref AttributeDataValue local = ref value;
      System.IntPtr pointer = zero;
      AttributeDataValue attributeDataValue = pointer == System.IntPtr.Zero ? (AttributeDataValue) null : new AttributeDataValue(pointer);
      local = attributeDataValue;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1123118, RefRangeEnd = 1123121, XrefRangeStart = 1123116, XrefRangeEnd = 1123118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Apply(SessionData newVersion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newVersion));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_Apply_Public_Void_SessionData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123121, XrefRangeEnd = 1123482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string ToString(uint indentCount)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &indentCount;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_ToString_Public_String_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1123551, RefRangeEnd = 1123554, XrefRangeStart = 1123482, XrefRangeEnd = 1123551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Equals(Il2CppSystem.Object obj)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123554, XrefRangeEnd = 1123568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123568, XrefRangeEnd = 1123572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(SessionData left, SessionData right)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) left));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) right));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SessionData_SessionData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123572, XrefRangeEnd = 1123576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(SessionData left, SessionData right)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) left));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) right));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SessionData_SessionData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123576, XrefRangeEnd = 1123585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CreateSessionModificationOptions ToCreateSessionModificationOptions(
      PlatformInterface platformInterface,
      string sessionName,
      bool usePresence,
      bool useSanctions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sessionName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &usePresence;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &useSanctions;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_ToCreateSessionModificationOptions_Public_CreateSessionModificationOptions_PlatformInterface_String_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new CreateSessionModificationOptions(pointer);
    }

    [CallerCount(25)]
    [CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionModificationSetJoinInProgressAllowedOptions ToSessionModificationSetJoinInProgressAllowedOptions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_ToSessionModificationSetJoinInProgressAllowedOptions_Public_SessionModificationSetJoinInProgressAllowedOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SessionModificationSetJoinInProgressAllowedOptions*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1858)]
    [CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionModificationSetInvitesAllowedOptions ToSessionModificationSetInvitesAllowedOptions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_ToSessionModificationSetInvitesAllowedOptions_Public_SessionModificationSetInvitesAllowedOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SessionModificationSetInvitesAllowedOptions*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionModificationSetPermissionLevelOptions ToSessionModificationSetPermissionLevelOptions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_ToSessionModificationSetPermissionLevelOptions_Public_SessionModificationSetPermissionLevelOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SessionModificationSetPermissionLevelOptions*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123585, XrefRangeEnd = 1123587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionModificationSetHostAddressOptions ToSessionModificationSetHostAddressOptions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_ToSessionModificationSetHostAddressOptions_Public_SessionModificationSetHostAddressOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new SessionModificationSetHostAddressOptions(pointer);
    }

    [CallerCount(33)]
    [CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionModificationSetMaxPlayersOptions ToSessionModificationSetMaxPlayersOptions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_ToSessionModificationSetMaxPlayersOptions_Public_SessionModificationSetMaxPlayersOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SessionModificationSetMaxPlayersOptions*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123587, XrefRangeEnd = 1123591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionModificationSetBucketIdOptions ToSessionModificationSetBucketIdOptions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SessionData.NativeMethodInfoPtr_ToSessionModificationSetBucketIdOptions_Public_SessionModificationSetBucketIdOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new SessionModificationSetBucketIdOptions(pointer);
    }

    static SessionData()
    {
      Il2CppClassPointerStore<SessionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.EOS", nameof (SessionData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionData>.NativeClassPtr);
      SessionData.NativeFieldInfoPtr_LogHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, nameof (LogHeader));
      SessionData.NativeFieldInfoPtr__HostAddress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "<HostAddress>k__BackingField");
      SessionData.NativeFieldInfoPtr__MaxPlayers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "<MaxPlayers>k__BackingField");
      SessionData.NativeFieldInfoPtr__SessionAttributes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "<SessionAttributes>k__BackingField");
      SessionData.NativeMethodInfoPtr_get_HostAddress_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689117);
      SessionData.NativeMethodInfoPtr_set_HostAddress_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689118);
      SessionData.NativeMethodInfoPtr_get_MaxPlayers_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689119);
      SessionData.NativeMethodInfoPtr_set_MaxPlayers_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689120);
      SessionData.NativeMethodInfoPtr_get_BucketId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689121);
      SessionData.NativeMethodInfoPtr_get_AllowJoinInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689122);
      SessionData.NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689123);
      SessionData.NativeMethodInfoPtr_get_PermissionLevel_Public_get_OnlineSessionPermissionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689124);
      SessionData.NativeMethodInfoPtr_get_SessionAttributes_Public_get_Dictionary_2_String_KeyValuePair_2_AttributeDataValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689125);
      SessionData.NativeMethodInfoPtr_set_SessionAttributes_Private_set_Void_Dictionary_2_String_KeyValuePair_2_AttributeDataValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689126);
      SessionData.NativeMethodInfoPtr__ctor_Public_Void_SessionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689127);
      SessionData.NativeMethodInfoPtr__ctor_Public_Void_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689128);
      SessionData.NativeMethodInfoPtr_SetAttribute_Public_Void_SessionAttribute_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689129);
      SessionData.NativeMethodInfoPtr_UnsetAttribute_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689130);
      SessionData.NativeMethodInfoPtr_TryGetAttribute_Public_Boolean_String_byref_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689131);
      SessionData.NativeMethodInfoPtr_TryGetAttributeOfType_Public_Boolean_String_AttributeType_byref_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689132);
      SessionData.NativeMethodInfoPtr_Apply_Public_Void_SessionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689133);
      SessionData.NativeMethodInfoPtr_ToString_Public_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689134);
      SessionData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689135);
      SessionData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689136);
      SessionData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SessionData_SessionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689137);
      SessionData.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SessionData_SessionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689138);
      SessionData.NativeMethodInfoPtr_ToCreateSessionModificationOptions_Public_CreateSessionModificationOptions_PlatformInterface_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689139);
      SessionData.NativeMethodInfoPtr_ToSessionModificationSetJoinInProgressAllowedOptions_Public_SessionModificationSetJoinInProgressAllowedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689140);
      SessionData.NativeMethodInfoPtr_ToSessionModificationSetInvitesAllowedOptions_Public_SessionModificationSetInvitesAllowedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689141);
      SessionData.NativeMethodInfoPtr_ToSessionModificationSetPermissionLevelOptions_Public_SessionModificationSetPermissionLevelOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689142);
      SessionData.NativeMethodInfoPtr_ToSessionModificationSetHostAddressOptions_Public_SessionModificationSetHostAddressOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689143);
      SessionData.NativeMethodInfoPtr_ToSessionModificationSetMaxPlayersOptions_Public_SessionModificationSetMaxPlayersOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689144);
      SessionData.NativeMethodInfoPtr_ToSessionModificationSetBucketIdOptions_Public_SessionModificationSetBucketIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100689145);
    }

    public SessionData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SessionData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SessionData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionData>.NativeClassPtr, data));
    }

    public static unsafe string LogHeader
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(SessionData.NativeFieldInfoPtr_LogHeader, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionData.NativeFieldInfoPtr_LogHeader, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _HostAddress_k__BackingField
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionData.NativeFieldInfoPtr__HostAddress_k__BackingField)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionData.NativeFieldInfoPtr__HostAddress_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe uint _MaxPlayers_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionData.NativeFieldInfoPtr__MaxPlayers_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionData.NativeFieldInfoPtr__MaxPlayers_k__BackingField)) = value;
      }
    }

    public unsafe Dictionary<string, KeyValuePair<AttributeDataValue, bool>> _SessionAttributes_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionData.NativeFieldInfoPtr__SessionAttributes_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, KeyValuePair<AttributeDataValue, bool>>) null : new Dictionary<string, KeyValuePair<AttributeDataValue, bool>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionData.NativeFieldInfoPtr__SessionAttributes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
