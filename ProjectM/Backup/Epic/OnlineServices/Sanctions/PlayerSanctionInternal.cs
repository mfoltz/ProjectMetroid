// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sanctions.PlayerSanctionInternal
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
  [StructLayout(LayoutKind.Explicit)]
  public struct PlayerSanctionInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TimePlaced;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Action;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TimeExpires;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ReferenceId;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TimePlaced_Public_get_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TimePlaced_Public_set_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Action_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Action_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeExpires_Public_get_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeExpires_Public_set_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ReferenceId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReferenceId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PlayerSanction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PlayerSanction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PlayerSanction_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public long m_TimePlaced;
    [FieldOffset(16)]
    public System.IntPtr m_Action;
    [FieldOffset(24)]
    public long m_TimeExpires;
    [FieldOffset(32)]
    public System.IntPtr m_ReferenceId;

    public unsafe long TimePlaced
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_get_TimePlaced_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_set_TimePlaced_Public_set_Void_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Action
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943317, XrefRangeEnd = 943321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_get_Action_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943321, XrefRangeEnd = 943325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_set_Action_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe long TimeExpires
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_get_TimeExpires_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_set_TimeExpires_Public_set_Void_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ReferenceId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943325, XrefRangeEnd = 943329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_get_ReferenceId_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943329, XrefRangeEnd = 943333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_set_ReferenceId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943333, XrefRangeEnd = 943341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref PlayerSanction other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PlayerSanction_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943341, XrefRangeEnd = 943359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<PlayerSanction> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PlayerSanction_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943359, XrefRangeEnd = 943364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943364, XrefRangeEnd = 943365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out PlayerSanction output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PlayerSanction_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayerSanction local = ref output;
      System.IntPtr pointer = zero;
      PlayerSanction playerSanction = pointer == System.IntPtr.Zero ? (PlayerSanction) null : new PlayerSanction(pointer);
      local = playerSanction;
    }

    static PlayerSanctionInternal()
    {
      Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sanctions", nameof (PlayerSanctionInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr);
      PlayerSanctionInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, nameof (m_ApiVersion));
      PlayerSanctionInternal.NativeFieldInfoPtr_m_TimePlaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, nameof (m_TimePlaced));
      PlayerSanctionInternal.NativeFieldInfoPtr_m_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, nameof (m_Action));
      PlayerSanctionInternal.NativeFieldInfoPtr_m_TimeExpires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, nameof (m_TimeExpires));
      PlayerSanctionInternal.NativeFieldInfoPtr_m_ReferenceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, nameof (m_ReferenceId));
      PlayerSanctionInternal.NativeMethodInfoPtr_get_TimePlaced_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666770);
      PlayerSanctionInternal.NativeMethodInfoPtr_set_TimePlaced_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666771);
      PlayerSanctionInternal.NativeMethodInfoPtr_get_Action_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666772);
      PlayerSanctionInternal.NativeMethodInfoPtr_set_Action_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666773);
      PlayerSanctionInternal.NativeMethodInfoPtr_get_TimeExpires_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666774);
      PlayerSanctionInternal.NativeMethodInfoPtr_set_TimeExpires_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666775);
      PlayerSanctionInternal.NativeMethodInfoPtr_get_ReferenceId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666776);
      PlayerSanctionInternal.NativeMethodInfoPtr_set_ReferenceId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666777);
      PlayerSanctionInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PlayerSanction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666778);
      PlayerSanctionInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PlayerSanction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666779);
      PlayerSanctionInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666780);
      PlayerSanctionInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PlayerSanction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666781);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
