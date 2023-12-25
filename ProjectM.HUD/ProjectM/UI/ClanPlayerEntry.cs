// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ClanPlayerEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ClanPlayerEntry : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterHUDSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthFrameImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecoveryImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthRecentDamageTakenImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlineColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_OfflineColor;
    private static readonly System.IntPtr NativeFieldInfoPtr__HealthChunks;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentData;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HealthChunks_Public_get_List_1_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ClanPlayerEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHealth_Public_Void_Data_TeamHUDSetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupChunks_Public_Void_List_1_GameObject_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe List<GameObject> HealthChunks
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClanPlayerEntry.NativeMethodInfoPtr_get_HealthChunks_Public_get_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<GameObject>) null : new List<GameObject>(pointer);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1221629, RefRangeEnd = 1221630, XrefRangeStart = 1221607, XrefRangeEnd = 1221629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RefreshData(ClanPlayerEntry entry, ClanPlayerEntry.Data data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanPlayerEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ClanPlayerEntry_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221630, XrefRangeEnd = 1221639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateHealth(
      ClanPlayerEntry.Data data,
      CharacterHUDSettings.TeamHUDSetting settings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &settings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanPlayerEntry.NativeMethodInfoPtr_UpdateHealth_Public_Void_Data_TeamHUDSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1221675, RefRangeEnd = 1221676, XrefRangeStart = 1221639, XrefRangeEnd = 1221675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupChunks(List<GameObject> chunkList, float maxValue, float valuePerChunk = 20f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) chunkList);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &valuePerChunk;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanPlayerEntry.NativeMethodInfoPtr_SetupChunks_Public_Void_List_1_GameObject_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221676, XrefRangeEnd = 1221684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClanPlayerEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanPlayerEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClanPlayerEntry()
    {
      Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ClanPlayerEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr);
      ClanPlayerEntry.NativeFieldInfoPtr_CharacterHUDSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, nameof (CharacterHUDSettings));
      ClanPlayerEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, nameof (Name));
      ClanPlayerEntry.NativeFieldInfoPtr_HealthImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, nameof (HealthImage));
      ClanPlayerEntry.NativeFieldInfoPtr_HealthFrameImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, nameof (HealthFrameImage));
      ClanPlayerEntry.NativeFieldInfoPtr_RecoveryImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, nameof (RecoveryImage));
      ClanPlayerEntry.NativeFieldInfoPtr_HealthRecentDamageTakenImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, nameof (HealthRecentDamageTakenImage));
      ClanPlayerEntry.NativeFieldInfoPtr_OnlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, nameof (OnlineColor));
      ClanPlayerEntry.NativeFieldInfoPtr_OfflineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, nameof (OfflineColor));
      ClanPlayerEntry.NativeFieldInfoPtr__HealthChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, nameof (_HealthChunks));
      ClanPlayerEntry.NativeFieldInfoPtr__CurrentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, nameof (_CurrentData));
      ClanPlayerEntry.NativeMethodInfoPtr_get_HealthChunks_Public_get_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, 100664701);
      ClanPlayerEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ClanPlayerEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, 100664702);
      ClanPlayerEntry.NativeMethodInfoPtr_UpdateHealth_Public_Void_Data_TeamHUDSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, 100664703);
      ClanPlayerEntry.NativeMethodInfoPtr_SetupChunks_Public_Void_List_1_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, 100664704);
      ClanPlayerEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, 100664705);
    }

    public ClanPlayerEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CharacterHUDSettings CharacterHUDSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_CharacterHUDSettings));
        return pointer == System.IntPtr.Zero ? (CharacterHUDSettings) null : new CharacterHUDSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_CharacterHUDSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Name
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_Name));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image HealthImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_HealthImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_HealthImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image HealthFrameImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_HealthFrameImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_HealthFrameImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image RecoveryImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_RecoveryImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_RecoveryImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image HealthRecentDamageTakenImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_HealthRecentDamageTakenImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_HealthRecentDamageTakenImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color OnlineColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_OnlineColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_OnlineColor)) = value;
      }
    }

    public unsafe Color OfflineColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_OfflineColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr_OfflineColor)) = value;
      }
    }

    public unsafe List<GameObject> _HealthChunks
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr__HealthChunks));
        return pointer == System.IntPtr.Zero ? (List<GameObject>) null : new List<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr__HealthChunks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public ClanPlayerEntry.Data _CurrentData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr__CurrentData);
        return new ClanPlayerEntry.Data(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.NativeFieldInfoPtr__CurrentData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsOnline;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealth;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_RecoveryFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_RecentDamageTakenFill;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1221592, RefRangeEnd = 1221593, XrefRangeStart = 1221587, XrefRangeEnd = 1221592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(ClanPlayerEntry.Data other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClanPlayerEntry.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221593, XrefRangeEnd = 1221601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe bool Equals(Il2CppSystem.Object obj)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClanPlayerEntry.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221601, XrefRangeEnd = 1221607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClanPlayerEntry.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Data()
      {
        Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanPlayerEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr);
        ClanPlayerEntry.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr, nameof (Name));
        ClanPlayerEntry.Data.NativeFieldInfoPtr_IsOnline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr, nameof (IsOnline));
        ClanPlayerEntry.Data.NativeFieldInfoPtr_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr, nameof (MaxHealth));
        ClanPlayerEntry.Data.NativeFieldInfoPtr_HealthFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr, nameof (HealthFill));
        ClanPlayerEntry.Data.NativeFieldInfoPtr_RecoveryFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr, nameof (RecoveryFill));
        ClanPlayerEntry.Data.NativeFieldInfoPtr_RecentDamageTakenFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr, nameof (RecentDamageTakenFill));
        ClanPlayerEntry.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr, 100664706);
        ClanPlayerEntry.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr, 100664707);
        ClanPlayerEntry.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr, 100664708);
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanPlayerEntry.Data>.NativeClassPtr, data));
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.Data.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.Data.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe bool IsOnline
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.Data.NativeFieldInfoPtr_IsOnline));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.Data.NativeFieldInfoPtr_IsOnline)) = value;
        }
      }

      public unsafe float MaxHealth
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.Data.NativeFieldInfoPtr_MaxHealth));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.Data.NativeFieldInfoPtr_MaxHealth)) = value;
        }
      }

      public unsafe float HealthFill
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.Data.NativeFieldInfoPtr_HealthFill));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.Data.NativeFieldInfoPtr_HealthFill)) = value;
        }
      }

      public unsafe float RecoveryFill
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.Data.NativeFieldInfoPtr_RecoveryFill));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.Data.NativeFieldInfoPtr_RecoveryFill)) = value;
        }
      }

      public unsafe float RecentDamageTakenFill
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.Data.NativeFieldInfoPtr_RecentDamageTakenFill));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanPlayerEntry.Data.NativeFieldInfoPtr_RecentDamageTakenFill)) = value;
        }
      }
    }
  }
}
