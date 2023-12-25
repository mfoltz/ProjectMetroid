// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.PlayerStatInfoInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlayerStatInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ThresholdValue;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentValue_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ThresholdValue_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ThresholdValue_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PlayerStatInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PlayerStatInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PlayerStatInfo_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Name;
    [FieldOffset(16)]
    public int m_CurrentValue;
    [FieldOffset(20)]
    public int m_ThresholdValue;

    public unsafe Epic.OnlineServices.Utf8String Name
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974122, XrefRangeEnd = 974126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_get_Name_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974126, XrefRangeEnd = 974130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_set_Name_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int CurrentValue
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_get_CurrentValue_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_set_CurrentValue_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int ThresholdValue
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 23498, RefRangeEnd = 23499, XrefRangeStart = 23498, XrefRangeEnd = 23499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_get_ThresholdValue_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 23499, RefRangeEnd = 23501, XrefRangeStart = 23499, XrefRangeEnd = 23501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_set_ThresholdValue_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974130, XrefRangeEnd = 974134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref PlayerStatInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PlayerStatInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974134, XrefRangeEnd = 974146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<PlayerStatInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PlayerStatInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974146, XrefRangeEnd = 974150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974150, XrefRangeEnd = 974151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out PlayerStatInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PlayerStatInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayerStatInfo local = ref output;
      System.IntPtr pointer = zero;
      PlayerStatInfo playerStatInfo = pointer == System.IntPtr.Zero ? (PlayerStatInfo) null : new PlayerStatInfo(pointer);
      local = playerStatInfo;
    }

    static PlayerStatInfoInternal()
    {
      Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Achievements", nameof (PlayerStatInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr);
      PlayerStatInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
      PlayerStatInfoInternal.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, nameof (m_Name));
      PlayerStatInfoInternal.NativeFieldInfoPtr_m_CurrentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, nameof (m_CurrentValue));
      PlayerStatInfoInternal.NativeFieldInfoPtr_m_ThresholdValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, nameof (m_ThresholdValue));
      PlayerStatInfoInternal.NativeMethodInfoPtr_get_Name_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100675220);
      PlayerStatInfoInternal.NativeMethodInfoPtr_set_Name_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100675221);
      PlayerStatInfoInternal.NativeMethodInfoPtr_get_CurrentValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100675222);
      PlayerStatInfoInternal.NativeMethodInfoPtr_set_CurrentValue_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100675223);
      PlayerStatInfoInternal.NativeMethodInfoPtr_get_ThresholdValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100675224);
      PlayerStatInfoInternal.NativeMethodInfoPtr_set_ThresholdValue_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100675225);
      PlayerStatInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PlayerStatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100675226);
      PlayerStatInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PlayerStatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100675227);
      PlayerStatInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100675228);
      PlayerStatInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PlayerStatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100675229);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
