// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.DefinitionV2Internal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DefinitionV2Internal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UnlockedDisplayName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UnlockedDescription;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LockedDisplayName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LockedDescription;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_FlavorText;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UnlockedIconURL;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LockedIconURL;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IsHidden;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StatThresholdsCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StatThresholds;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AchievementId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockedDisplayName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UnlockedDisplayName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockedDescription_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UnlockedDescription_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LockedDisplayName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LockedDisplayName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LockedDescription_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LockedDescription_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FlavorText_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_FlavorText_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockedIconURL_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UnlockedIconURL_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LockedIconURL_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LockedIconURL_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsHidden_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsHidden_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StatThresholds_Public_get_Il2CppReferenceArray_1_StatThresholds_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StatThresholds_Public_set_Void_Il2CppReferenceArray_1_StatThresholds_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_DefinitionV2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_DefinitionV2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_DefinitionV2_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_AchievementId;
    [FieldOffset(16)]
    public System.IntPtr m_UnlockedDisplayName;
    [FieldOffset(24)]
    public System.IntPtr m_UnlockedDescription;
    [FieldOffset(32)]
    public System.IntPtr m_LockedDisplayName;
    [FieldOffset(40)]
    public System.IntPtr m_LockedDescription;
    [FieldOffset(48)]
    public System.IntPtr m_FlavorText;
    [FieldOffset(56)]
    public System.IntPtr m_UnlockedIconURL;
    [FieldOffset(64)]
    public System.IntPtr m_LockedIconURL;
    [FieldOffset(72)]
    public int m_IsHidden;
    [FieldOffset(76)]
    public uint m_StatThresholdsCount;
    [FieldOffset(80)]
    public System.IntPtr m_StatThresholds;

    public unsafe Epic.OnlineServices.Utf8String AchievementId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973328, XrefRangeEnd = 973332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_AchievementId_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973332, XrefRangeEnd = 973336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String UnlockedDisplayName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973336, XrefRangeEnd = 973340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_UnlockedDisplayName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973340, XrefRangeEnd = 973344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_UnlockedDisplayName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String UnlockedDescription
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973344, XrefRangeEnd = 973348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_UnlockedDescription_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973348, XrefRangeEnd = 973352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_UnlockedDescription_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String LockedDisplayName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973352, XrefRangeEnd = 973356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_LockedDisplayName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973356, XrefRangeEnd = 973360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_LockedDisplayName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String LockedDescription
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973360, XrefRangeEnd = 973364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_LockedDescription_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973364, XrefRangeEnd = 973368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_LockedDescription_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String FlavorText
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973368, XrefRangeEnd = 973372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_FlavorText_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973372, XrefRangeEnd = 973376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_FlavorText_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String UnlockedIconURL
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973376, XrefRangeEnd = 973380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_UnlockedIconURL_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973380, XrefRangeEnd = 973384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_UnlockedIconURL_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String LockedIconURL
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973384, XrefRangeEnd = 973388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_LockedIconURL_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973388, XrefRangeEnd = 973392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_LockedIconURL_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsHidden
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973392, XrefRangeEnd = 973396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_IsHidden_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973396, XrefRangeEnd = 973400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_IsHidden_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds> StatThresholds
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 973406, RefRangeEnd = 973407, XrefRangeStart = 973400, XrefRangeEnd = 973406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_StatThresholds_Public_get_Il2CppReferenceArray_1_StatThresholds_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds>) null : new Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds>(nativeObject);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 973413, RefRangeEnd = 973415, XrefRangeStart = 973407, XrefRangeEnd = 973413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_StatThresholds_Public_set_Void_Il2CppReferenceArray_1_StatThresholds_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973415, XrefRangeEnd = 973452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref DefinitionV2 other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_DefinitionV2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973452, XrefRangeEnd = 973511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<DefinitionV2> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_DefinitionV2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973511, XrefRangeEnd = 973523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973523, XrefRangeEnd = 973524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out DefinitionV2 output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_DefinitionV2_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref DefinitionV2 local = ref output;
      System.IntPtr pointer = zero;
      DefinitionV2 definitionV2 = pointer == System.IntPtr.Zero ? (DefinitionV2) null : new DefinitionV2(pointer);
      local = definitionV2;
    }

    static DefinitionV2Internal()
    {
      Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Achievements", nameof (DefinitionV2Internal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr);
      DefinitionV2Internal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_ApiVersion));
      DefinitionV2Internal.NativeFieldInfoPtr_m_AchievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_AchievementId));
      DefinitionV2Internal.NativeFieldInfoPtr_m_UnlockedDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_UnlockedDisplayName));
      DefinitionV2Internal.NativeFieldInfoPtr_m_UnlockedDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_UnlockedDescription));
      DefinitionV2Internal.NativeFieldInfoPtr_m_LockedDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_LockedDisplayName));
      DefinitionV2Internal.NativeFieldInfoPtr_m_LockedDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_LockedDescription));
      DefinitionV2Internal.NativeFieldInfoPtr_m_FlavorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_FlavorText));
      DefinitionV2Internal.NativeFieldInfoPtr_m_UnlockedIconURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_UnlockedIconURL));
      DefinitionV2Internal.NativeFieldInfoPtr_m_LockedIconURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_LockedIconURL));
      DefinitionV2Internal.NativeFieldInfoPtr_m_IsHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_IsHidden));
      DefinitionV2Internal.NativeFieldInfoPtr_m_StatThresholdsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_StatThresholdsCount));
      DefinitionV2Internal.NativeFieldInfoPtr_m_StatThresholds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_StatThresholds));
      DefinitionV2Internal.NativeMethodInfoPtr_get_AchievementId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100674998);
      DefinitionV2Internal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100674999);
      DefinitionV2Internal.NativeMethodInfoPtr_get_UnlockedDisplayName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675000);
      DefinitionV2Internal.NativeMethodInfoPtr_set_UnlockedDisplayName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675001);
      DefinitionV2Internal.NativeMethodInfoPtr_get_UnlockedDescription_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675002);
      DefinitionV2Internal.NativeMethodInfoPtr_set_UnlockedDescription_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675003);
      DefinitionV2Internal.NativeMethodInfoPtr_get_LockedDisplayName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675004);
      DefinitionV2Internal.NativeMethodInfoPtr_set_LockedDisplayName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675005);
      DefinitionV2Internal.NativeMethodInfoPtr_get_LockedDescription_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675006);
      DefinitionV2Internal.NativeMethodInfoPtr_set_LockedDescription_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675007);
      DefinitionV2Internal.NativeMethodInfoPtr_get_FlavorText_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675008);
      DefinitionV2Internal.NativeMethodInfoPtr_set_FlavorText_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675009);
      DefinitionV2Internal.NativeMethodInfoPtr_get_UnlockedIconURL_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675010);
      DefinitionV2Internal.NativeMethodInfoPtr_set_UnlockedIconURL_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675011);
      DefinitionV2Internal.NativeMethodInfoPtr_get_LockedIconURL_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675012);
      DefinitionV2Internal.NativeMethodInfoPtr_set_LockedIconURL_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675013);
      DefinitionV2Internal.NativeMethodInfoPtr_get_IsHidden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675014);
      DefinitionV2Internal.NativeMethodInfoPtr_set_IsHidden_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675015);
      DefinitionV2Internal.NativeMethodInfoPtr_get_StatThresholds_Public_get_Il2CppReferenceArray_1_StatThresholds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675016);
      DefinitionV2Internal.NativeMethodInfoPtr_set_StatThresholds_Public_set_Void_Il2CppReferenceArray_1_StatThresholds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675017);
      DefinitionV2Internal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_DefinitionV2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675018);
      DefinitionV2Internal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_DefinitionV2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675019);
      DefinitionV2Internal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675020);
      DefinitionV2Internal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_DefinitionV2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100675021);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
