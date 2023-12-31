// Decompiled with JetBrains decompiler
// Type: ProjectM.PlayerInteractionSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Network;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class PlayerInteractionSettings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeZone;
    private static readonly System.IntPtr NativeFieldInfoPtr_VSPlayerWeekdayTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_VSPlayerWeekendTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_VSCastleWeekdayTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_VSCastleWeekendTime;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_StructData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 758414, RefRangeEnd = 758415, XrefRangeStart = 758410, XrefRangeEnd = 758414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerInteractionSettings.StructData Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerInteractionSettings.NativeMethodInfoPtr_Convert_Public_StructData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlayerInteractionSettings.StructData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 758440, RefRangeEnd = 758441, XrefRangeStart = 758415, XrefRangeEnd = 758440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerInteractionSettings.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerInteractionSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInteractionSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerInteractionSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlayerInteractionSettings()
    {
      Il2CppClassPointerStore<PlayerInteractionSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PlayerInteractionSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInteractionSettings>.NativeClassPtr);
      PlayerInteractionSettings.NativeFieldInfoPtr_TimeZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionSettings>.NativeClassPtr, nameof (TimeZone));
      PlayerInteractionSettings.NativeFieldInfoPtr_VSPlayerWeekdayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionSettings>.NativeClassPtr, nameof (VSPlayerWeekdayTime));
      PlayerInteractionSettings.NativeFieldInfoPtr_VSPlayerWeekendTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionSettings>.NativeClassPtr, nameof (VSPlayerWeekendTime));
      PlayerInteractionSettings.NativeFieldInfoPtr_VSCastleWeekdayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionSettings>.NativeClassPtr, nameof (VSCastleWeekdayTime));
      PlayerInteractionSettings.NativeFieldInfoPtr_VSCastleWeekendTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionSettings>.NativeClassPtr, nameof (VSCastleWeekendTime));
      PlayerInteractionSettings.NativeMethodInfoPtr_Convert_Public_StructData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractionSettings>.NativeClassPtr, 100666919);
      PlayerInteractionSettings.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractionSettings>.NativeClassPtr, 100666920);
      PlayerInteractionSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractionSettings>.NativeClassPtr, 100666921);
    }

    public PlayerInteractionSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameTimeZone TimeZone
    {
      get
      {
        return *(GameTimeZone*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerInteractionSettings.NativeFieldInfoPtr_TimeZone));
      }
      [param: In] set
      {
        *(GameTimeZone*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerInteractionSettings.NativeFieldInfoPtr_TimeZone)) = value;
      }
    }

    public unsafe StartEndTimeData VSPlayerWeekdayTime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerInteractionSettings.NativeFieldInfoPtr_VSPlayerWeekdayTime));
        return pointer == System.IntPtr.Zero ? (StartEndTimeData) null : new StartEndTimeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerInteractionSettings.NativeFieldInfoPtr_VSPlayerWeekdayTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StartEndTimeData VSPlayerWeekendTime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerInteractionSettings.NativeFieldInfoPtr_VSPlayerWeekendTime));
        return pointer == System.IntPtr.Zero ? (StartEndTimeData) null : new StartEndTimeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerInteractionSettings.NativeFieldInfoPtr_VSPlayerWeekendTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StartEndTimeData VSCastleWeekdayTime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerInteractionSettings.NativeFieldInfoPtr_VSCastleWeekdayTime));
        return pointer == System.IntPtr.Zero ? (StartEndTimeData) null : new StartEndTimeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerInteractionSettings.NativeFieldInfoPtr_VSCastleWeekdayTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StartEndTimeData VSCastleWeekendTime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerInteractionSettings.NativeFieldInfoPtr_VSCastleWeekendTime));
        return pointer == System.IntPtr.Zero ? (StartEndTimeData) null : new StartEndTimeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerInteractionSettings.NativeFieldInfoPtr_VSCastleWeekendTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StructData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TimeZone;
      private static readonly System.IntPtr NativeFieldInfoPtr_VSPlayerWeekdayTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_VSPlayerWeekendTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_VSCastleWeekdayTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_VSCastleWeekendTime;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_StructData_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetDateTime_Private_DateTime_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IsVSPlayerActive_Public_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IsVSCastleActive_Public_Boolean_0;
      [FieldOffset(0)]
      public GameTimeZone TimeZone;
      [FieldOffset(4)]
      public StartEndTimeData.StructData VSPlayerWeekdayTime;
      [FieldOffset(8)]
      public StartEndTimeData.StructData VSPlayerWeekendTime;
      [FieldOffset(12)]
      public StartEndTimeData.StructData VSCastleWeekdayTime;
      [FieldOffset(16)]
      public StartEndTimeData.StructData VSCastleWeekendTime;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758379, RefRangeEnd = 758380, XrefRangeStart = 758374, XrefRangeEnd = 758379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Serialize(
        PlayerInteractionSettings.StructData settings,
        ref NetBufferOut netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &settings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerInteractionSettings.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_StructData_byref_NetBufferOut_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758385, RefRangeEnd = 758386, XrefRangeStart = 758380, XrefRangeEnd = 758385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe PlayerInteractionSettings.StructData Deserialize(
        ref NetBufferIn netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerInteractionSettings.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PlayerInteractionSettings.StructData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 758390, RefRangeEnd = 758392, XrefRangeStart = 758386, XrefRangeEnd = 758390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Il2CppSystem.DateTime GetDateTime()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerInteractionSettings.StructData.NativeMethodInfoPtr_GetDateTime_Private_DateTime_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Il2CppSystem.DateTime*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758399, RefRangeEnd = 758400, XrefRangeStart = 758392, XrefRangeEnd = 758399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool IsVSPlayerActive()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerInteractionSettings.StructData.NativeMethodInfoPtr_IsVSPlayerActive_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 758407, RefRangeEnd = 758410, XrefRangeStart = 758400, XrefRangeEnd = 758407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool IsVSCastleActive()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerInteractionSettings.StructData.NativeMethodInfoPtr_IsVSCastleActive_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static StructData()
      {
        Il2CppClassPointerStore<PlayerInteractionSettings.StructData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInteractionSettings>.NativeClassPtr, nameof (StructData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInteractionSettings.StructData>.NativeClassPtr);
        PlayerInteractionSettings.StructData.NativeFieldInfoPtr_TimeZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionSettings.StructData>.NativeClassPtr, nameof (TimeZone));
        PlayerInteractionSettings.StructData.NativeFieldInfoPtr_VSPlayerWeekdayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionSettings.StructData>.NativeClassPtr, nameof (VSPlayerWeekdayTime));
        PlayerInteractionSettings.StructData.NativeFieldInfoPtr_VSPlayerWeekendTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionSettings.StructData>.NativeClassPtr, nameof (VSPlayerWeekendTime));
        PlayerInteractionSettings.StructData.NativeFieldInfoPtr_VSCastleWeekdayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionSettings.StructData>.NativeClassPtr, nameof (VSCastleWeekdayTime));
        PlayerInteractionSettings.StructData.NativeFieldInfoPtr_VSCastleWeekendTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteractionSettings.StructData>.NativeClassPtr, nameof (VSCastleWeekendTime));
        PlayerInteractionSettings.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_StructData_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractionSettings.StructData>.NativeClassPtr, 100666922);
        PlayerInteractionSettings.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractionSettings.StructData>.NativeClassPtr, 100666923);
        PlayerInteractionSettings.StructData.NativeMethodInfoPtr_GetDateTime_Private_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractionSettings.StructData>.NativeClassPtr, 100666924);
        PlayerInteractionSettings.StructData.NativeMethodInfoPtr_IsVSPlayerActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractionSettings.StructData>.NativeClassPtr, 100666925);
        PlayerInteractionSettings.StructData.NativeMethodInfoPtr_IsVSCastleActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteractionSettings.StructData>.NativeClassPtr, 100666926);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerInteractionSettings.StructData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
