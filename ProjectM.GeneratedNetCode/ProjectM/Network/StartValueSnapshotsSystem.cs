// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.StartValueSnapshotsSystem
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.CastleBuilding;
using ProjectM.Gameplay;
using ProjectM.Gameplay.Scripting;
using ProjectM.Hybrid;
using ProjectM.Sequencer;
using ProjectM.Shared;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Network
{
  public class StartValueSnapshotsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SnapshotQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RegisterEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkSnapshotTypeValues;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkSnapshotTypeIndexes;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkSnapshotTypes;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupJob_Private_Void_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1611540, XrefRangeEnd = 1611570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StartValueSnapshotsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1611570, XrefRangeEnd = 1611573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StartValueSnapshotsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1612234, RefRangeEnd = 1612235, XrefRangeStart = 1611573, XrefRangeEnd = 1612234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupJob(
      ref StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams jobParams)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.NativeMethodInfoPtr_SetupJob_Private_Void_byref_JobParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1612235, XrefRangeEnd = 1612275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StartValueSnapshotsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1612275, XrefRangeEnd = 1612290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StartValueSnapshotsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StartValueSnapshotsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StartValueSnapshotsSystem()
    {
      Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (StartValueSnapshotsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr);
      StartValueSnapshotsSystem.NativeFieldInfoPtr__SnapshotQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr, nameof (_SnapshotQuery));
      StartValueSnapshotsSystem.NativeFieldInfoPtr__RegisterEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr, nameof (_RegisterEventQuery));
      StartValueSnapshotsSystem.NativeFieldInfoPtr__NetworkSnapshotTypeValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr, nameof (_NetworkSnapshotTypeValues));
      StartValueSnapshotsSystem.NativeFieldInfoPtr__NetworkSnapshotTypeIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr, nameof (_NetworkSnapshotTypeIndexes));
      StartValueSnapshotsSystem.NativeFieldInfoPtr__NetworkSnapshotTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr, nameof (_NetworkSnapshotTypes));
      StartValueSnapshotsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr, 100664750);
      StartValueSnapshotsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr, 100664751);
      StartValueSnapshotsSystem.NativeMethodInfoPtr_SetupJob_Private_Void_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr, 100664752);
      StartValueSnapshotsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr, 100664753);
      StartValueSnapshotsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr, 100664754);
      StartValueSnapshotsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr, 100664755);
    }

    public StartValueSnapshotsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _SnapshotQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartValueSnapshotsSystem.NativeFieldInfoPtr__SnapshotQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartValueSnapshotsSystem.NativeFieldInfoPtr__SnapshotQuery)) = value;
      }
    }

    public unsafe EntityQuery _RegisterEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartValueSnapshotsSystem.NativeFieldInfoPtr__RegisterEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartValueSnapshotsSystem.NativeFieldInfoPtr__RegisterEventQuery)) = value;
      }
    }

    public unsafe List<NetworkSnapshotType> _NetworkSnapshotTypeValues
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartValueSnapshotsSystem.NativeFieldInfoPtr__NetworkSnapshotTypeValues));
        return pointer == System.IntPtr.Zero ? (List<NetworkSnapshotType>) null : new List<NetworkSnapshotType>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartValueSnapshotsSystem.NativeFieldInfoPtr__NetworkSnapshotTypeValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<int> _NetworkSnapshotTypeIndexes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartValueSnapshotsSystem.NativeFieldInfoPtr__NetworkSnapshotTypeIndexes));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartValueSnapshotsSystem.NativeFieldInfoPtr__NetworkSnapshotTypeIndexes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeHashMap<int, NetworkSnapshotType> _NetworkSnapshotTypes
    {
      get
      {
        return *(NativeHashMap<int, NetworkSnapshotType>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartValueSnapshotsSystem.NativeFieldInfoPtr__NetworkSnapshotTypes));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartValueSnapshotsSystem.NativeFieldInfoPtr__NetworkSnapshotTypes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, NetworkSnapshotType>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StartValueSnapshotsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkSnapshotTypeLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr_SharedNetworkSnapshotType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetworkId;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetSnapshotType;
      private static readonly System.IntPtr NativeFieldInfoPtr_Params;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acbbdiefgbd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acbbgiidegf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acbdgdebikk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acbfcjichfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acbhckcfdfd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acbhkjccgdi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acbicfeedbb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acbiddcjjid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acccfjkdigh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acccgefcedb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_accdbefiheb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_accdjiedgfe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_accgciikfbf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_accgiggcif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acchhgcjcbh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acchibekekj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acciegkehkf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acdccjhicfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acdehhkijdj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acdfgkkfchc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acdficciidc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acdibbekbkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acdidhjbjgj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acdjdjkckhd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acdjighgcci_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acdkgjbefjd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acdkkhcbdcg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acecggedbff_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aceegbjekgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aceehcgeedj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acegbdcgkdf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aceihfcgifd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acekdgegehc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acekjgheehk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acfckgbfifj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acfebiceeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acfhdekidie_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acfikjcfik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acgbiiekebj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acgchdfhdbe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acgckficfjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acgddgdckdd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acgefcgggfi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acgfefhihji_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acggehdijfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acggfcbekbj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acggkbfbjck_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acghdchgjgf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_achbffjechg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_achbhefgeeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_achbhhddbh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_achcbdhidik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_achdjgjdgkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_achfcefeheb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_achgedhdigf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_achgegcdkcj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_achicekidek_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_achiggdccdc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_achjkedegdi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_achjkicgkif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aciddedkjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acidekciged_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acidjkkbgbk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acifkidfebh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acigkbdedfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acihcehbbb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acihehkdfeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acihkdjfdkb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aciibbeciec_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acikghjjgki_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acikhjeehkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acjbgiffidc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acjdegcccg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acjigbfeikj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_acjkcgkfjff_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ackbhgekeci_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ackchfegcjc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ackdkfeghk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ackebkbdbjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ackffdikde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ackgdbibjbd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ackifjdcjjd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ackjbcfijee_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ackkecjdkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adbbickeikd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adbfkibeiid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adbfkjhfcjd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adbgiccjej_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adbhchjbgek_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adbijghdjjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adbjcebiefe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adbjdjfkiif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adbjkedbgjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adbjkhhkffi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adbkdbehhdh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adcbfjighfe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adcdbdebfjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adcffdijihg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adejkghcfk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adekhbkfjb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adgbkkgkkc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adgcbgkcfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adjbidcgdh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_adkecehjdk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aebfefikfc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aegjbedggh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aeibfebcie_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aejfcffkde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_afcdibbdhk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_afdcikchcf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_afdgichhbg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_afdgigchdc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_afejhccjki_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_afgfgihgc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_afghjhgcgk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_afibjfgjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_afiidbjjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_afkbfgfhef_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_agcdkcdjfe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_agfgchgici_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aggchckijc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_agghikgigk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aghhkgkfc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_agijkdicg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_agjkgikkig_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_agkckkkggd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ahbgechgbk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ahciehbbdc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ahiggbegei_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ahijjfgjce_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ahkcgijbei_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ahkijdhjcb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aicgdjfcgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aidbefcifj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aidcegcehg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aiebecdijh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aieefjchbd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aiejbddfde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aifejkfbkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aifkcjfiic_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_aigchgfejj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ajcejdgdjc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ajchjhccfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ajfedjbbig_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ajghhigdb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ajgkhchijb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ajkhbehfkf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_akdddhikjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_akdhbfiiid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_akfbbffjcg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_akgbiefjbh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_akhbjjbcei_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_akhiekbd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_akidjkegkj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_akjcidekhd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_akjiekjkkh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cbbeifjkdj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cbffeddche_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cbggkebbfk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cbhkgfiiif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cbjidfdhfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cbkcbhjiek_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cbkfhfcjb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ccbfibgeci_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cccffebffc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cccggcfdkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ccekgicgfh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ccfhfbhikj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ccgjgbjcgi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cchfdhghjd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cddckigibk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cdedfgfkdj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cdfdcchhe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cdfibdbkfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cdfjfbikid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cdgbkkidfd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cdgibkchih_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cdidfjjidb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cdjkcdjcgc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cebdekghcc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ceceehkkdb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cechbcjbje_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cechggbfcg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cechibbibc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cedekbhedh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ceecjebgfd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ceffhbdbf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cegbicbcfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cegkcgkkgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ceiggdddik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cejhdeejck_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cekhfceefg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cfbedkikg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cfbjdedjcj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cfbjghgjgf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cfcfjiceg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cfcjbdhdik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cfcjgefdjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cfedcgehh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cfffedbhfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cfiggjfcfh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cfjbbdjcdi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cfkdeghg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cgbbhfbgbj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cgbeibighh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cgdieefdkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cghhdebggi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cgighkjefc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cgjchkijib_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_chdckkkgkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_chedkdbce_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_chhcdcgigb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_chibdbkfde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_chibgkeeji_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_chiceijbgj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_chiffhjbee_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_chiiihhffh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cichefikeb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cicjgdikig_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cifbcfjkdj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cigfkckdgc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cijeifhgec_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cijijgbkgk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cjbcjhhgke_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cjbjeehdbk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cjdkihjijd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cjfdcbgfgj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cjgbfhfgef_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cjhkjfhhf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cjicjgdfff_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cjjdbgbddi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cjjdkdfkkh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_cjjjckihek_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ckbiikefid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ckeiejdgib_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ckkddehif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dbbbcebccf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dbedicfecc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dbfehhjdb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dbibcdhcc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dbjjcgeeki_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dcbffdidkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dcbkfgcjid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dcdjbbkec_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dcebfkhcgc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dcecciefge_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dcehkgkifb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dcfehdgdkj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ddffjifbf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ddikijcge_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_debdghice_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dfcjdjkjk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dfjibkhbh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_dihkeehk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_djigibich_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ebgkehdgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ecgibfdjb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_edfkjgfch_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ehkcekjii_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_eidhfehik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_eiehjkdd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ejjgbkdff_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ejkdcifhg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_fbejgkdib_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_fdjggbfcb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_fdkkidgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_fekcijijf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_fgcbdbbid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_fgfckhdf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_fhcdfebdc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_fhjkfjice_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_fihfdkijh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_fjkikekhi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_fkbkbchgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_fkedkejgf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_fkfbciibe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_gbchjfieb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_gbibihicb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_geijfbdhc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_gfgdjegbe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_gihjfdefi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_gjgidfgeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_hbeefgbjc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_hcehhjdfk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_hekdkcdeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_hfjfeiijk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_hhbehfckd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_hhkbgdice_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_hikdcfgkb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_hkdbgkgik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ibbddjcfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ichfccfhh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_idchgghie_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_iddeebfkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_iddhiekfi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_idjfhgckc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ihbgcbhic_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_iicekghif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_iifbheddf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_ikejdbedk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_jcdhbjde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_jceehdeeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_jchhdjhkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_jgcekgbii_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_jigekbbhd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_jjjcegjeg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_jkekeckbf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_kbcfjkedc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_kdbikhddc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_kddgijibc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_kdhdheib_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_kfbbiddfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_kfkchgjdd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_kiighbfgg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSnapshot_kijdhbiid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunJobForChunk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0;
      [FieldOffset(0)]
      public NativeHashMap<int, NetworkSnapshotType> NetworkSnapshotTypeLookup;
      [FieldOffset(16)]
      public SharedComponentTypeHandle<NetworkSnapshotType> SharedNetworkSnapshotType;
      [FieldOffset(24)]
      public ComponentDataFromEntity<NetworkId> GetNetworkId;
      [FieldOffset(56)]
      public BufferTypeHandle<NetSnapshot> NetSnapshotType;
      [FieldOffset(96)]
      public StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams Params;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1590712, RefRangeEnd = 1590713, XrefRangeStart = 1590648, XrefRangeEnd = 1590712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acbbdiefgbd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbbdiefgbd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1590713, XrefRangeEnd = 1590755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acbbgiidegf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbbgiidegf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1590755, XrefRangeEnd = 1590994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acbdgdebikk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbdgdebikk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1590994, XrefRangeEnd = 1591029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acbfcjichfb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbfcjichfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591029, XrefRangeEnd = 1591142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acbhckcfdfd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbhckcfdfd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591142, XrefRangeEnd = 1591252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acbhkjccgdi(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbhkjccgdi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591252, XrefRangeEnd = 1591295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acbicfeedbb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbicfeedbb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591295, XrefRangeEnd = 1591330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acbiddcjjid(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbiddcjjid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591330, XrefRangeEnd = 1591424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acccfjkdigh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acccfjkdigh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591424, XrefRangeEnd = 1591501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acccgefcedb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acccgefcedb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591501, XrefRangeEnd = 1591567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_accdbefiheb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_accdbefiheb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591567, XrefRangeEnd = 1591680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_accdjiedgfe(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_accdjiedgfe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591680, XrefRangeEnd = 1591739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_accgciikfbf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_accgciikfbf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591739, XrefRangeEnd = 1591767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_accgiggcif(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_accgiggcif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591767, XrefRangeEnd = 1591817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acchhgcjcbh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acchhgcjcbh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591817, XrefRangeEnd = 1591851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acchibekekj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acchibekekj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591851, XrefRangeEnd = 1591961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acciegkehkf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acciegkehkf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591961, XrefRangeEnd = 1591983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acdccjhicfg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdccjhicfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1591983, XrefRangeEnd = 1592080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acdehhkijdj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdehhkijdj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592080, XrefRangeEnd = 1592184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acdfgkkfchc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdfgkkfchc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592184, XrefRangeEnd = 1592256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acdficciidc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdficciidc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592256, XrefRangeEnd = 1592331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acdibbekbkk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdibbekbkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592331, XrefRangeEnd = 1592422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acdidhjbjgj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdidhjbjgj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592422, XrefRangeEnd = 1592474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acdjdjkckhd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdjdjkckhd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592474, XrefRangeEnd = 1592502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acdjighgcci(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdjighgcci_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592502, XrefRangeEnd = 1592521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acdkgjbefjd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdkgjbefjd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592521, XrefRangeEnd = 1592589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acdkkhcbdcg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdkkhcbdcg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592589, XrefRangeEnd = 1592623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acecggedbff(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acecggedbff_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592623, XrefRangeEnd = 1592785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aceegbjekgb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aceegbjekgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592785, XrefRangeEnd = 1592833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aceehcgeedj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aceehcgeedj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592833, XrefRangeEnd = 1592887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acegbdcgkdf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acegbdcgkdf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592887, XrefRangeEnd = 1592947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aceihfcgifd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aceihfcgifd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592947, XrefRangeEnd = 1592978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acekdgegehc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acekdgegehc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1592978, XrefRangeEnd = 1593019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acekjgheehk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acekjgheehk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1593019, XrefRangeEnd = 1593107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acfckgbfifj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acfckgbfifj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1593107, XrefRangeEnd = 1593202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acfebiceeh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acfebiceeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1593202, XrefRangeEnd = 1593258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acfhdekidie(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acfhdekidie_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1593258, XrefRangeEnd = 1593286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acfikjcfik(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acfikjcfik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1593286, XrefRangeEnd = 1593328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acgbiiekebj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acgbiiekebj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1593328, XrefRangeEnd = 1593393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acgchdfhdbe(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acgchdfhdbe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1593393, XrefRangeEnd = 1593574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acgckficfjg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acgckficfjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1593574, XrefRangeEnd = 1593609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acgddgdckdd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acgddgdckdd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1593609, XrefRangeEnd = 1593720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acgefcgggfi(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acgefcgggfi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1593720, XrefRangeEnd = 1593781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acgfefhihji(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acgfefhihji_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1593781, XrefRangeEnd = 1593823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acggehdijfg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acggehdijfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1593823, XrefRangeEnd = 1593860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acggfcbekbj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acggfcbekbj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1593860, XrefRangeEnd = 1594006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acggkbfbjck(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acggkbfbjck_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594006, XrefRangeEnd = 1594109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acghdchgjgf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acghdchgjgf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594109, XrefRangeEnd = 1594183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_achbffjechg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achbffjechg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594183, XrefRangeEnd = 1594288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_achbhefgeeh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achbhefgeeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594288, XrefRangeEnd = 1594338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_achbhhddbh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achbhhddbh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594338, XrefRangeEnd = 1594383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_achcbdhidik(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achcbdhidik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594383, XrefRangeEnd = 1594408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_achdjgjdgkk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achdjgjdgkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594408, XrefRangeEnd = 1594456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_achfcefeheb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achfcefeheb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594456, XrefRangeEnd = 1594503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_achgedhdigf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achgedhdigf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594503, XrefRangeEnd = 1594551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_achgegcdkcj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achgegcdkcj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594551, XrefRangeEnd = 1594667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_achicekidek(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achicekidek_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594667, XrefRangeEnd = 1594692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_achiggdccdc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achiggdccdc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594692, XrefRangeEnd = 1594711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_achjkedegdi(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achjkedegdi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594711, XrefRangeEnd = 1594860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_achjkicgkif(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achjkicgkif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594860, XrefRangeEnd = 1594891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aciddedkjj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aciddedkjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594891, XrefRangeEnd = 1594949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acidekciged(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acidekciged_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594949, XrefRangeEnd = 1594989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acidjkkbgbk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acidjkkbgbk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1594989, XrefRangeEnd = 1595048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acifkidfebh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acifkidfebh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595048, XrefRangeEnd = 1595110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acigkbdedfb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acigkbdedfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595110, XrefRangeEnd = 1595148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acihcehbbb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acihcehbbb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595148, XrefRangeEnd = 1595229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acihehkdfeh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acihehkdfeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595229, XrefRangeEnd = 1595257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acihkdjfdkb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acihkdjfdkb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595257, XrefRangeEnd = 1595285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aciibbeciec(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aciibbeciec_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595285, XrefRangeEnd = 1595313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acikghjjgki(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acikghjjgki_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595313, XrefRangeEnd = 1595364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acikhjeehkg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acikhjeehkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595364, XrefRangeEnd = 1595445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acjbgiffidc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acjbgiffidc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595445, XrefRangeEnd = 1595653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acjdegcccg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acjdegcccg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595653, XrefRangeEnd = 1595687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acjigbfeikj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acjigbfeikj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595687, XrefRangeEnd = 1595775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_acjkcgkfjff(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acjkcgkfjff_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595775, XrefRangeEnd = 1595797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ackbhgekeci(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackbhgekeci_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595797, XrefRangeEnd = 1595816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ackchfegcjc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackchfegcjc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595816, XrefRangeEnd = 1595978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ackdkfeghk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackdkfeghk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595978, XrefRangeEnd = 1596003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ackebkbdbjj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackebkbdbjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596003, XrefRangeEnd = 1596041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ackffdikde(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackffdikde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596041, XrefRangeEnd = 1596124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ackgdbibjbd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackgdbibjbd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596124, XrefRangeEnd = 1596169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ackifjdcjjd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackifjdcjjd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596169, XrefRangeEnd = 1596211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ackjbcfijee(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackjbcfijee_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596211, XrefRangeEnd = 1596260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ackkecjdkk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackkecjdkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596260, XrefRangeEnd = 1596282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adbbickeikd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbbickeikd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596282, XrefRangeEnd = 1596322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adbfkibeiid(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbfkibeiid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596322, XrefRangeEnd = 1596344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adbfkjhfcjd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbfkjhfcjd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596344, XrefRangeEnd = 1596386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adbgiccjej(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbgiccjej_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596386, XrefRangeEnd = 1596417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adbhchjbgek(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbhchjbgek_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596417, XrefRangeEnd = 1596450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adbijghdjjj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbijghdjjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596450, XrefRangeEnd = 1596493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adbjcebiefe(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbjcebiefe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596493, XrefRangeEnd = 1596587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adbjdjfkiif(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbjdjfkiif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596587, XrefRangeEnd = 1596667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adbjkedbgjg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbjkedbgjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596667, XrefRangeEnd = 1596744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adbjkhhkffi(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbjkhhkffi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596744, XrefRangeEnd = 1596781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adbkdbehhdh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbkdbehhdh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596781, XrefRangeEnd = 1596838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adcbfjighfe(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adcbfjighfe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596838, XrefRangeEnd = 1596886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adcdbdebfjg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adcdbdebfjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596886, XrefRangeEnd = 1596969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adcffdijihg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adcffdijihg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1596969, XrefRangeEnd = 1597090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adejkghcfk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adejkghcfk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1597090, XrefRangeEnd = 1597115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adekhbkfjb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adekhbkfjb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1597115, XrefRangeEnd = 1597149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adgbkkgkkc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adgbkkgkkc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1597149, XrefRangeEnd = 1597193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adgcbgkcfb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adgcbgkcfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1597193, XrefRangeEnd = 1597282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adjbidcgdh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adjbidcgdh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1597282, XrefRangeEnd = 1597316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_adkecehjdk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adkecehjdk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1597316, XrefRangeEnd = 1597364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aebfefikfc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aebfefikfc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1597364, XrefRangeEnd = 1597395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aegjbedggh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aegjbedggh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1597395, XrefRangeEnd = 1597439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aeibfebcie(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aeibfebcie_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1597439, XrefRangeEnd = 1597479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aejfcffkde(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aejfcffkde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1597479, XrefRangeEnd = 1597516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_afcdibbdhk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afcdibbdhk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1597516, XrefRangeEnd = 1597607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_afdcikchcf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afdcikchcf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1597607, XrefRangeEnd = 1597750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_afdgichhbg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afdgichhbg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1597750, XrefRangeEnd = 1597795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_afdgigchdc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afdgigchdc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1597795, XrefRangeEnd = 1598036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_afejhccjki(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afejhccjki_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1598036, XrefRangeEnd = 1598228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_afgfgihgc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afgfgihgc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1598228, XrefRangeEnd = 1598276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_afghjhgcgk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afghjhgcgk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1598276, XrefRangeEnd = 1598402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_afibjfgjj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afibjfgjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1598402, XrefRangeEnd = 1598496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_afiidbjjg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afiidbjjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1598496, XrefRangeEnd = 1598681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_afkbfgfhef(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afkbfgfhef_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1598681, XrefRangeEnd = 1598785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_agcdkcdjfe(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_agcdkcdjfe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1598785, XrefRangeEnd = 1598816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_agfgchgici(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_agfgchgici_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1598816, XrefRangeEnd = 1598879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aggchckijc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aggchckijc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1598879, XrefRangeEnd = 1598933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_agghikgigk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_agghikgigk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1598933, XrefRangeEnd = 1598985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aghhkgkfc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aghhkgkfc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1598985, XrefRangeEnd = 1599041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_agijkdicg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_agijkdicg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1599041, XrefRangeEnd = 1599110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_agjkgikkig(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_agjkgikkig_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1599110, XrefRangeEnd = 1599180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_agkckkkggd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_agkckkkggd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1599180, XrefRangeEnd = 1599214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ahbgechgbk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ahbgechgbk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1599214, XrefRangeEnd = 1599261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ahciehbbdc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ahciehbbdc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1599261, XrefRangeEnd = 1599335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ahiggbegei(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ahiggbegei_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1599335, XrefRangeEnd = 1599475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ahijjfgjce(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ahijjfgjce_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1599475, XrefRangeEnd = 1599497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ahkcgijbei(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ahkcgijbei_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1599497, XrefRangeEnd = 1599543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ahkijdhjcb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ahkijdhjcb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1599543, XrefRangeEnd = 1599588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aicgdjfcgb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aicgdjfcgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1599588, XrefRangeEnd = 1599685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aidbefcifj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aidbefcifj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1599685, XrefRangeEnd = 1599863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aidcegcehg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aidcegcehg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1599863, XrefRangeEnd = 1599891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aiebecdijh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aiebecdijh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1599891, XrefRangeEnd = 1599979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aieefjchbd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aieefjchbd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1599979, XrefRangeEnd = 1600105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aiejbddfde(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aiejbddfde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600105, XrefRangeEnd = 1600218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aifejkfbkk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aifejkfbkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600218, XrefRangeEnd = 1600255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aifkcjfiic(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aifkcjfiic_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600255, XrefRangeEnd = 1600312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_aigchgfejj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aigchgfejj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600312, XrefRangeEnd = 1600361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ajcejdgdjc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ajcejdgdjc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600361, XrefRangeEnd = 1600403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ajchjhccfg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ajchjhccfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600403, XrefRangeEnd = 1600483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ajfedjbbig(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ajfedjbbig_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600483, XrefRangeEnd = 1600518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ajghhigdb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ajghhigdb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600518, XrefRangeEnd = 1600556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ajgkhchijb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ajgkhchijb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600556, XrefRangeEnd = 1600605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ajkhbehfkf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ajkhbehfkf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600605, XrefRangeEnd = 1600657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_akdddhikjj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akdddhikjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600657, XrefRangeEnd = 1600702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_akdhbfiiid(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akdhbfiiid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600702, XrefRangeEnd = 1600736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_akfbbffjcg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akfbbffjcg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600736, XrefRangeEnd = 1600770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_akgbiefjbh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akgbiefjbh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600770, XrefRangeEnd = 1600858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_akhbjjbcei(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akhbjjbcei_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600858, XrefRangeEnd = 1600886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_akhiekbd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akhiekbd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600886, XrefRangeEnd = 1600917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_akidjkegkj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akidjkegkj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1600917, XrefRangeEnd = 1601008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_akjcidekhd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akjcidekhd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601008, XrefRangeEnd = 1601036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_akjiekjkkh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akjiekjkkh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601036, XrefRangeEnd = 1601067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cbbeifjkdj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cbbeifjkdj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601067, XrefRangeEnd = 1601086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cbffeddche(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cbffeddche_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601086, XrefRangeEnd = 1601131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cbggkebbfk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cbggkebbfk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601131, XrefRangeEnd = 1601321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cbhkgfiiif(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cbhkgfiiif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601321, XrefRangeEnd = 1601399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cbjidfdhfg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cbjidfdhfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601399, XrefRangeEnd = 1601459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cbkcbhjiek(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cbkcbhjiek_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601459, XrefRangeEnd = 1601501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cbkfhfcjb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cbkfhfcjb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601501, XrefRangeEnd = 1601526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ccbfibgeci(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ccbfibgeci_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601526, XrefRangeEnd = 1601581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cccffebffc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cccffebffc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601581, XrefRangeEnd = 1601597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cccggcfdkg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cccggcfdkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601597, XrefRangeEnd = 1601682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ccekgicgfh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ccekgicgfh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601682, XrefRangeEnd = 1601719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ccfhfbhikj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ccfhfbhikj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601719, XrefRangeEnd = 1601777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ccgjgbjcgi(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ccgjgbjcgi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601777, XrefRangeEnd = 1601890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cchfdhghjd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cchfdhghjd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1601890, XrefRangeEnd = 1602039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cddckigibk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cddckigibk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1602039, XrefRangeEnd = 1602228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cdedfgfkdj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdedfgfkdj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1602228, XrefRangeEnd = 1602304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cdfdcchhe(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdfdcchhe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1602304, XrefRangeEnd = 1602384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cdfibdbkfb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdfibdbkfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1602384, XrefRangeEnd = 1602500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cdfjfbikid(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdfjfbikid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1602500, XrefRangeEnd = 1602678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cdgbkkidfd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdgbkkidfd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1602678, XrefRangeEnd = 1602723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cdgibkchih(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdgibkchih_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1602723, XrefRangeEnd = 1602774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cdidfjjidb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdidfjjidb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1602774, XrefRangeEnd = 1602814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cdjkcdjcgc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdjkcdjcgc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1602814, XrefRangeEnd = 1602852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cebdekghcc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cebdekghcc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1602852, XrefRangeEnd = 1602949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ceceehkkdb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ceceehkkdb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1602949, XrefRangeEnd = 1602977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cechbcjbje(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cechbcjbje_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1602977, XrefRangeEnd = 1603002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cechggbfcg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cechggbfcg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1603002, XrefRangeEnd = 1603195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cechibbibc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cechibbibc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1603195, XrefRangeEnd = 1603494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cedekbhedh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cedekbhedh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1603494, XrefRangeEnd = 1603539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ceecjebgfd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ceecjebgfd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1603539, XrefRangeEnd = 1603602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ceffhbdbf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ceffhbdbf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1603602, XrefRangeEnd = 1603733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cegbicbcfg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cegbicbcfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1603733, XrefRangeEnd = 1603816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cegkcgkkgb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cegkcgkkgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1603816, XrefRangeEnd = 1603890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ceiggdddik(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ceiggdddik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1603890, XrefRangeEnd = 1603909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cejhdeejck(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cejhdeejck_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1603909, XrefRangeEnd = 1604003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cekhfceefg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cekhfceefg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1604003, XrefRangeEnd = 1604085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cfbedkikg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfbedkikg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1604085, XrefRangeEnd = 1604195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cfbjdedjcj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfbjdedjcj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1604195, XrefRangeEnd = 1604406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cfbjghgjgf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfbjghgjgf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1604406, XrefRangeEnd = 1604459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cfcfjiceg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfcfjiceg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1604459, XrefRangeEnd = 1604542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cfcjbdhdik(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfcjbdhdik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1604542, XrefRangeEnd = 1604611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cfcjgefdjg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfcjgefdjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1604611, XrefRangeEnd = 1604656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cfedcgehh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfedcgehh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1604656, XrefRangeEnd = 1604687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cfffedbhfg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfffedbhfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1604687, XrefRangeEnd = 1604735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cfiggjfcfh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfiggjfcfh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1604735, XrefRangeEnd = 1604854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cfjbbdjcdi(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfjbbdjcdi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1604854, XrefRangeEnd = 1604898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cfkdeghg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfkdeghg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1604898, XrefRangeEnd = 1604929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cgbbhfbgbj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cgbbhfbgbj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1604929, XrefRangeEnd = 1604982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cgbeibighh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cgbeibighh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1604982, XrefRangeEnd = 1605016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cgdieefdkk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cgdieefdkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605016, XrefRangeEnd = 1605047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cghhdebggi(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cghhdebggi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605047, XrefRangeEnd = 1605144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cgighkjefc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cgighkjefc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605144, XrefRangeEnd = 1605204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cgjchkijib(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cgjchkijib_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605204, XrefRangeEnd = 1605223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_chdckkkgkg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chdckkkgkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605223, XrefRangeEnd = 1605332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_chedkdbce(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chedkdbce_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605332, XrefRangeEnd = 1605455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_chhcdcgigb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chhcdcgigb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605455, XrefRangeEnd = 1605558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_chibdbkfde(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chibdbkfde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605558, XrefRangeEnd = 1605586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_chibgkeeji(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chibgkeeji_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605586, XrefRangeEnd = 1605674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_chiceijbgj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chiceijbgj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605674, XrefRangeEnd = 1605693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_chiffhjbee(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chiffhjbee_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605693, XrefRangeEnd = 1605731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_chiiihhffh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chiiihhffh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605731, XrefRangeEnd = 1605844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cichefikeb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cichefikeb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605844, XrefRangeEnd = 1605863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cicjgdikig(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cicjgdikig_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605863, XrefRangeEnd = 1605970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cifbcfjkdj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cifbcfjkdj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605970, XrefRangeEnd = 1606099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cigfkckdgc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cigfkckdgc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606099, XrefRangeEnd = 1606141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cijeifhgec(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cijeifhgec_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606141, XrefRangeEnd = 1606352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cijijgbkgk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cijijgbkgk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606352, XrefRangeEnd = 1606371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cjbcjhhgke(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjbcjhhgke_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606371, XrefRangeEnd = 1606436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cjbjeehdbk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjbjeehdbk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606436, XrefRangeEnd = 1606509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cjdkihjijd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjdkihjijd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606509, XrefRangeEnd = 1606537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cjfdcbgfgj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjfdcbgfgj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606537, XrefRangeEnd = 1606575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cjgbfhfgef(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjgbfhfgef_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606575, XrefRangeEnd = 1606619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cjhkjfhhf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjhkjfhhf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606619, XrefRangeEnd = 1606744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cjicjgdfff(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjicjgdfff_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606744, XrefRangeEnd = 1606775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cjjdbgbddi(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjjdbgbddi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606775, XrefRangeEnd = 1606846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cjjdkdfkkh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjjdkdfkkh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606846, XrefRangeEnd = 1606887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_cjjjckihek(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjjjckihek_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606887, XrefRangeEnd = 1606981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ckbiikefid(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ckbiikefid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606981, XrefRangeEnd = 1607029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ckeiejdgib(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ckeiejdgib_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607029, XrefRangeEnd = 1607082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ckkddehif(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ckkddehif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607082, XrefRangeEnd = 1607122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dbbbcebccf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dbbbcebccf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607122, XrefRangeEnd = 1607169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dbedicfecc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dbedicfecc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607169, XrefRangeEnd = 1607221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dbfehhjdb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dbfehhjdb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607221, XrefRangeEnd = 1607255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dbibcdhcc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dbibcdhcc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607255, XrefRangeEnd = 1607297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dbjjcgeeki(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dbjjcgeeki_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607297, XrefRangeEnd = 1607371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dcbffdidkk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dcbffdidkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607371, XrefRangeEnd = 1607428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dcbkfgcjid(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dcbkfgcjid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607428, XrefRangeEnd = 1607470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dcdjbbkec(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dcdjbbkec_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607470, XrefRangeEnd = 1607495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dcebfkhcgc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dcebfkhcgc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607495, XrefRangeEnd = 1607517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dcecciefge(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dcecciefge_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607517, XrefRangeEnd = 1607548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dcehkgkifb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dcehkgkifb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607548, XrefRangeEnd = 1607580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dcfehdgdkj(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dcfehdgdkj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607580, XrefRangeEnd = 1607696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ddffjifbf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ddffjifbf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607696, XrefRangeEnd = 1607730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ddikijcge(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ddikijcge_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607730, XrefRangeEnd = 1607783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_debdghice(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_debdghice_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607783, XrefRangeEnd = 1607828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dfcjdjkjk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dfcjdjkjk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607828, XrefRangeEnd = 1607919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dfjibkhbh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dfjibkhbh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607919, XrefRangeEnd = 1607987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_dihkeehk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dihkeehk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1607987, XrefRangeEnd = 1608042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_djigibich(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_djigibich_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1608042, XrefRangeEnd = 1608098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ebgkehdgb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ebgkehdgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1608098, XrefRangeEnd = 1608250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ecgibfdjb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ecgibfdjb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1608250, XrefRangeEnd = 1608292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_edfkjgfch(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_edfkjgfch_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1608292, XrefRangeEnd = 1608341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ehkcekjii(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ehkcekjii_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1608341, XrefRangeEnd = 1608432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_eidhfehik(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_eidhfehik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1608432, XrefRangeEnd = 1608480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_eiehjkdd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_eiehjkdd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1608480, XrefRangeEnd = 1608669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ejjgbkdff(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ejjgbkdff_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1608669, XrefRangeEnd = 1608697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ejkdcifhg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ejkdcifhg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1608697, XrefRangeEnd = 1608816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_fbejgkdib(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fbejgkdib_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1608816, XrefRangeEnd = 1608844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_fdjggbfcb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fdjggbfcb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1608844, XrefRangeEnd = 1608878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_fdkkidgb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fdkkidgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1608878, XrefRangeEnd = 1608943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_fekcijijf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fekcijijf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1608943, XrefRangeEnd = 1608977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_fgcbdbbid(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fgcbdbbid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1608977, XrefRangeEnd = 1609025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_fgfckhdf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fgfckhdf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609025, XrefRangeEnd = 1609062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_fhcdfebdc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fhcdfebdc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609062, XrefRangeEnd = 1609149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_fhjkfjice(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fhjkfjice_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609149, XrefRangeEnd = 1609180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_fihfdkijh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fihfdkijh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609180, XrefRangeEnd = 1609211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_fjkikekhi(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fjkikekhi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609211, XrefRangeEnd = 1609250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_fkbkbchgb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fkbkbchgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609250, XrefRangeEnd = 1609310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_fkedkejgf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fkedkejgf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609310, XrefRangeEnd = 1609406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_fkfbciibe(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fkfbciibe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609406, XrefRangeEnd = 1609441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_gbchjfieb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_gbchjfieb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609441, XrefRangeEnd = 1609541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_gbibihicb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_gbibihicb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609541, XrefRangeEnd = 1609632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_geijfbdhc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_geijfbdhc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609632, XrefRangeEnd = 1609680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_gfgdjegbe(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_gfgdjegbe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609680, XrefRangeEnd = 1609787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_gihjfdefi(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_gihjfdefi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609787, XrefRangeEnd = 1609818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_gjgidfgeh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_gjgidfgeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609818, XrefRangeEnd = 1609858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_hbeefgbjc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hbeefgbjc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609858, XrefRangeEnd = 1609943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_hcehhjdfk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hcehhjdfk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1609943, XrefRangeEnd = 1610069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_hekdkcdeh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hekdkcdeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610069, XrefRangeEnd = 1610088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_hfjfeiijk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hfjfeiijk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610088, XrefRangeEnd = 1610179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_hhbehfckd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hhbehfckd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610179, XrefRangeEnd = 1610239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_hhkbgdice(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hhkbgdice_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610239, XrefRangeEnd = 1610302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_hikdcfgkb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hikdcfgkb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610302, XrefRangeEnd = 1610330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_hkdbgkgik(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hkdbgkgik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610330, XrefRangeEnd = 1610380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ibbddjcfb(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ibbddjcfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610380, XrefRangeEnd = 1610414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ichfccfhh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ichfccfhh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610414, XrefRangeEnd = 1610442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_idchgghie(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_idchgghie_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610442, XrefRangeEnd = 1610487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_iddeebfkg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_iddeebfkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610487, XrefRangeEnd = 1610506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_iddhiekfi(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_iddhiekfi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610506, XrefRangeEnd = 1610536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_idjfhgckc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_idjfhgckc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610536, XrefRangeEnd = 1610625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ihbgcbhic(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ihbgcbhic_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610625, XrefRangeEnd = 1610653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_iicekghif(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_iicekghif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610653, XrefRangeEnd = 1610714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_iifbheddf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_iifbheddf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610714, XrefRangeEnd = 1610801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_ikejdbedk(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ikejdbedk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610801, XrefRangeEnd = 1610857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_jcdhbjde(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_jcdhbjde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610857, XrefRangeEnd = 1610909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_jceehdeeh(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_jceehdeeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610909, XrefRangeEnd = 1610954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_jchhdjhkg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_jchhdjhkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610954, XrefRangeEnd = 1610996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_jgcekgbii(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_jgcekgbii_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1610996, XrefRangeEnd = 1611021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_jigekbbhd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_jigekbbhd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1611021, XrefRangeEnd = 1611040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_jjjcegjeg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_jjjcegjeg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1611040, XrefRangeEnd = 1611113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_jkekeckbf(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_jkekeckbf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1611113, XrefRangeEnd = 1611206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_kbcfjkedc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kbcfjkedc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1611206, XrefRangeEnd = 1611225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_kdbikhddc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kdbikhddc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1611225, XrefRangeEnd = 1611343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_kddgijibc(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kddgijibc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1611343, XrefRangeEnd = 1611388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_kdhdheib(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kdhdheib_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1611388, XrefRangeEnd = 1611436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_kfbbiddfg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kfbbiddfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1611436, XrefRangeEnd = 1611478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_kfkchgjdd(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kfkchgjdd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1611478, XrefRangeEnd = 1611500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_kiighbfgg(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kiighbfgg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1611500, XrefRangeEnd = 1611531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateSnapshot_kijdhbiid(
        ArchetypeChunk chunk,
        NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kijdhbiid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1611531, XrefRangeEnd = 1611538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1611539, RefRangeEnd = 1611540, XrefRangeStart = 1611538, XrefRangeEnd = 1611539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void RunJobForChunk(ArchetypeChunk chunk, NetworkSnapshotType snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_RunJobForChunk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StartValueSnapshotsJob()
      {
        Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartValueSnapshotsSystem>.NativeClassPtr, nameof (StartValueSnapshotsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeFieldInfoPtr_NetworkSnapshotTypeLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, nameof (NetworkSnapshotTypeLookup));
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeFieldInfoPtr_SharedNetworkSnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, nameof (SharedNetworkSnapshotType));
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeFieldInfoPtr_GetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, nameof (GetNetworkId));
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeFieldInfoPtr_NetSnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, nameof (NetSnapshotType));
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeFieldInfoPtr_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, nameof (Params));
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbbdiefgbd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664756);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbbgiidegf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664757);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbdgdebikk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664758);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbfcjichfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664759);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbhckcfdfd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664760);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbhkjccgdi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664761);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbicfeedbb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664762);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acbiddcjjid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664763);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acccfjkdigh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664764);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acccgefcedb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664765);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_accdbefiheb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664766);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_accdjiedgfe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664767);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_accgciikfbf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664768);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_accgiggcif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664769);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acchhgcjcbh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664770);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acchibekekj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664771);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acciegkehkf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664772);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdccjhicfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664773);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdehhkijdj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664774);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdfgkkfchc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664775);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdficciidc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664776);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdibbekbkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664777);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdidhjbjgj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664778);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdjdjkckhd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664779);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdjighgcci_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664780);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdkgjbefjd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664781);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acdkkhcbdcg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664782);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acecggedbff_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664783);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aceegbjekgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664784);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aceehcgeedj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664785);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acegbdcgkdf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664786);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aceihfcgifd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664787);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acekdgegehc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664788);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acekjgheehk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664789);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acfckgbfifj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664790);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acfebiceeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664791);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acfhdekidie_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664792);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acfikjcfik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664793);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acgbiiekebj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664794);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acgchdfhdbe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664795);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acgckficfjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664796);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acgddgdckdd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664797);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acgefcgggfi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664798);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acgfefhihji_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664799);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acggehdijfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664800);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acggfcbekbj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664801);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acggkbfbjck_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664802);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acghdchgjgf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664803);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achbffjechg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664804);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achbhefgeeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664805);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achbhhddbh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664806);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achcbdhidik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664807);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achdjgjdgkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664808);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achfcefeheb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664809);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achgedhdigf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664810);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achgegcdkcj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664811);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achicekidek_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664812);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achiggdccdc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664813);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achjkedegdi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664814);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_achjkicgkif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664815);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aciddedkjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664816);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acidekciged_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664817);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acidjkkbgbk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664818);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acifkidfebh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664819);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acigkbdedfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664820);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acihcehbbb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664821);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acihehkdfeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664822);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acihkdjfdkb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664823);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aciibbeciec_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664824);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acikghjjgki_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664825);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acikhjeehkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664826);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acjbgiffidc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664827);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acjdegcccg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664828);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acjigbfeikj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664829);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_acjkcgkfjff_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664830);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackbhgekeci_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664831);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackchfegcjc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664832);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackdkfeghk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664833);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackebkbdbjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664834);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackffdikde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664835);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackgdbibjbd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664836);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackifjdcjjd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664837);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackjbcfijee_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664838);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ackkecjdkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664839);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbbickeikd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664840);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbfkibeiid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664841);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbfkjhfcjd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664842);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbgiccjej_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664843);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbhchjbgek_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664844);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbijghdjjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664845);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbjcebiefe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664846);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbjdjfkiif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664847);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbjkedbgjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664848);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbjkhhkffi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664849);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adbkdbehhdh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664850);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adcbfjighfe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664851);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adcdbdebfjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664852);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adcffdijihg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664853);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adejkghcfk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664854);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adekhbkfjb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664855);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adgbkkgkkc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664856);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adgcbgkcfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664857);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adjbidcgdh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664858);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_adkecehjdk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664859);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aebfefikfc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664860);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aegjbedggh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664861);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aeibfebcie_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664862);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aejfcffkde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664863);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afcdibbdhk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664864);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afdcikchcf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664865);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afdgichhbg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664866);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afdgigchdc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664867);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afejhccjki_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664868);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afgfgihgc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664869);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afghjhgcgk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664870);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afibjfgjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664871);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afiidbjjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664872);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_afkbfgfhef_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664873);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_agcdkcdjfe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664874);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_agfgchgici_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664875);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aggchckijc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664876);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_agghikgigk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664877);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aghhkgkfc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664878);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_agijkdicg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664879);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_agjkgikkig_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664880);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_agkckkkggd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664881);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ahbgechgbk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664882);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ahciehbbdc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664883);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ahiggbegei_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664884);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ahijjfgjce_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664885);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ahkcgijbei_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664886);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ahkijdhjcb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664887);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aicgdjfcgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664888);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aidbefcifj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664889);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aidcegcehg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664890);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aiebecdijh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664891);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aieefjchbd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664892);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aiejbddfde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664893);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aifejkfbkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664894);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aifkcjfiic_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664895);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_aigchgfejj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664896);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ajcejdgdjc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664897);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ajchjhccfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664898);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ajfedjbbig_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664899);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ajghhigdb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664900);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ajgkhchijb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664901);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ajkhbehfkf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664902);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akdddhikjj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664903);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akdhbfiiid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664904);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akfbbffjcg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664905);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akgbiefjbh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664906);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akhbjjbcei_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664907);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akhiekbd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664908);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akidjkegkj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664909);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akjcidekhd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664910);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_akjiekjkkh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664911);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cbbeifjkdj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664912);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cbffeddche_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664913);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cbggkebbfk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664914);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cbhkgfiiif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664915);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cbjidfdhfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664916);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cbkcbhjiek_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664917);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cbkfhfcjb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664918);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ccbfibgeci_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664919);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cccffebffc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664920);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cccggcfdkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664921);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ccekgicgfh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664922);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ccfhfbhikj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664923);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ccgjgbjcgi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664924);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cchfdhghjd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664925);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cddckigibk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664926);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdedfgfkdj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664927);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdfdcchhe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664928);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdfibdbkfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664929);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdfjfbikid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664930);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdgbkkidfd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664931);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdgibkchih_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664932);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdidfjjidb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664933);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cdjkcdjcgc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664934);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cebdekghcc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664935);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ceceehkkdb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664936);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cechbcjbje_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664937);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cechggbfcg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664938);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cechibbibc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664939);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cedekbhedh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664940);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ceecjebgfd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664941);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ceffhbdbf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664942);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cegbicbcfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664943);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cegkcgkkgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664944);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ceiggdddik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664945);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cejhdeejck_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664946);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cekhfceefg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664947);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfbedkikg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664948);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfbjdedjcj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664949);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfbjghgjgf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664950);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfcfjiceg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664951);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfcjbdhdik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664952);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfcjgefdjg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664953);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfedcgehh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664954);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfffedbhfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664955);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfiggjfcfh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664956);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfjbbdjcdi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664957);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cfkdeghg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664958);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cgbbhfbgbj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664959);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cgbeibighh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664960);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cgdieefdkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664961);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cghhdebggi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664962);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cgighkjefc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664963);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cgjchkijib_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664964);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chdckkkgkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664965);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chedkdbce_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664966);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chhcdcgigb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664967);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chibdbkfde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664968);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chibgkeeji_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664969);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chiceijbgj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664970);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chiffhjbee_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664971);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_chiiihhffh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664972);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cichefikeb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664973);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cicjgdikig_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664974);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cifbcfjkdj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664975);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cigfkckdgc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664976);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cijeifhgec_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664977);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cijijgbkgk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664978);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjbcjhhgke_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664979);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjbjeehdbk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664980);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjdkihjijd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664981);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjfdcbgfgj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664982);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjgbfhfgef_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664983);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjhkjfhhf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664984);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjicjgdfff_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664985);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjjdbgbddi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664986);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjjdkdfkkh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664987);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_cjjjckihek_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664988);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ckbiikefid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664989);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ckeiejdgib_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664990);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ckkddehif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664991);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dbbbcebccf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664992);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dbedicfecc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664993);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dbfehhjdb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664994);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dbibcdhcc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664995);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dbjjcgeeki_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664996);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dcbffdidkk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664997);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dcbkfgcjid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664998);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dcdjbbkec_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100664999);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dcebfkhcgc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665000);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dcecciefge_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665001);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dcehkgkifb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665002);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dcfehdgdkj_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665003);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ddffjifbf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665004);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ddikijcge_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665005);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_debdghice_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665006);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dfcjdjkjk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665007);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dfjibkhbh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665008);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_dihkeehk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665009);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_djigibich_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665010);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ebgkehdgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665011);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ecgibfdjb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665012);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_edfkjgfch_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665013);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ehkcekjii_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665014);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_eidhfehik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665015);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_eiehjkdd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665016);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ejjgbkdff_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665017);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ejkdcifhg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665018);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fbejgkdib_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665019);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fdjggbfcb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665020);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fdkkidgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665021);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fekcijijf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665022);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fgcbdbbid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665023);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fgfckhdf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665024);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fhcdfebdc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665025);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fhjkfjice_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665026);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fihfdkijh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665027);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fjkikekhi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665028);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fkbkbchgb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665029);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fkedkejgf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665030);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_fkfbciibe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665031);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_gbchjfieb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665032);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_gbibihicb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665033);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_geijfbdhc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665034);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_gfgdjegbe_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665035);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_gihjfdefi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665036);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_gjgidfgeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665037);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hbeefgbjc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665038);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hcehhjdfk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665039);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hekdkcdeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665040);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hfjfeiijk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665041);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hhbehfckd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665042);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hhkbgdice_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665043);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hikdcfgkb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665044);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_hkdbgkgik_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665045);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ibbddjcfb_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665046);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ichfccfhh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665047);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_idchgghie_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665048);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_iddeebfkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665049);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_iddhiekfi_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665050);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_idjfhgckc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665051);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ihbgcbhic_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665052);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_iicekghif_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665053);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_iifbheddf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665054);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_ikejdbedk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665055);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_jcdhbjde_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665056);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_jceehdeeh_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665057);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_jchhdjhkg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665058);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_jgcekgbii_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665059);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_jigekbbhd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665060);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_jjjcegjeg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665061);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_jkekeckbf_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665062);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kbcfjkedc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665063);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kdbikhddc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665064);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kddgijibc_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665065);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kdhdheib_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665066);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kfbbiddfg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665067);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kfkchgjdd_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665068);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kiighbfgg_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665069);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_UpdateSnapshot_kijdhbiid_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665070);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665071);
        StartValueSnapshotsSystem.StartValueSnapshotsJob.NativeMethodInfoPtr_RunJobForChunk_Private_Void_ArchetypeChunk_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, 100665072);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct JobParams
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUIDType;
        private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedSpawnChainChildType;
        private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatibleType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TeamType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TileModelType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleBuildingAttachedChildrenBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_CastleBuildingAttachedChildrenBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_BuffType;
        private static readonly System.IntPtr NativeFieldInfoPtr_EntityCreatorType;
        private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwnerType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Script_GarlicAreaDebuff_DataSharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_SharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_BagHolderType;
        private static readonly System.IntPtr NativeFieldInfoPtr_BloodType;
        private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagStateType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CanFlyType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CharacterVoiceActivityType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CombatMusicListener_SharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CustomizationFeaturesType;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeathRagdollForceType;
        private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollisionType;
        private static readonly System.IntPtr NativeFieldInfoPtr_EnergyType;
        private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentType;
        private static readonly System.IntPtr NativeFieldInfoPtr_FallToHeightType;
        private static readonly System.IntPtr NativeFieldInfoPtr_HealthType;
        private static readonly System.IntPtr NativeFieldInfoPtr_HeightType;
        private static readonly System.IntPtr NativeFieldInfoPtr_HybridModelSeedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_InteractedUponType;
        private static readonly System.IntPtr NativeFieldInfoPtr_IsSpellControlledType;
        private static readonly System.IntPtr NativeFieldInfoPtr_LifeLeechType;
        private static readonly System.IntPtr NativeFieldInfoPtr_MounterType;
        private static readonly System.IntPtr NativeFieldInfoPtr_MovementType;
        private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_SharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCharacterType;
        private static readonly System.IntPtr NativeFieldInfoPtr_RespawnCharacterType;
        private static readonly System.IntPtr NativeFieldInfoPtr_StealthableType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TakeDamageInSunType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirectionType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TravelToTargetRadiusType;
        private static readonly System.IntPtr NativeFieldInfoPtr_UnitStatsType;
        private static readonly System.IntPtr NativeFieldInfoPtr_VisionType;
        private static readonly System.IntPtr NativeFieldInfoPtr_FollowerBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_FollowerBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_InventoryInstanceElementType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_InventoryInstanceElementType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartConnectionType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CreatedTimeType;
        private static readonly System.IntPtr NativeFieldInfoPtr_DismantleDestroyDataType;
        private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileModelType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Wallpaper_FourSplitsType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleBuildingAttachToParentsBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_CastleBuildingAttachToParentsBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleRoofOrnamentsType;
        private static readonly System.IntPtr NativeFieldInfoPtr_LifeTimeType;
        private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntityType;
        private static readonly System.IntPtr NativeFieldInfoPtr_SpellMovementType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AggroConsumerType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AiMove_SharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_BloodConsumeSourceType;
        private static readonly System.IntPtr NativeFieldInfoPtr_UnitLevelType;
        private static readonly System.IntPtr NativeFieldInfoPtr_PlacementDestroyDataType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Wallpaper_TwoSplitsType;
        private static readonly System.IntPtr NativeFieldInfoPtr_DoorType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AbilityOwnerType;
        private static readonly System.IntPtr NativeFieldInfoPtr_RotationType;
        private static readonly System.IntPtr NativeFieldInfoPtr_DyeableCastleObjectType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ClanInviteRequest_SharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_MountableType;
        private static readonly System.IntPtr NativeFieldInfoPtr_NameableInteractableType;
        private static readonly System.IntPtr NativeFieldInfoPtr_SaddleBearerType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupStateType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AbilitySpellModItemType;
        private static readonly System.IntPtr NativeFieldInfoPtr_SpellModSetComponentType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AbilityStateBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_AbilityStateBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AbilityChargesStateType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AbilityTargetType;
        private static readonly System.IntPtr NativeFieldInfoPtr_SpellTargetType;
        private static readonly System.IntPtr NativeFieldInfoPtr_RotateOverTimeDataType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ProfessorCoilBeam_State_SharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_InventoryBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_InventoryBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_MapIconPositionType;
        private static readonly System.IntPtr NativeFieldInfoPtr_MapIconTargetEntityType;
        private static readonly System.IntPtr NativeFieldInfoPtr_WaypointMapIconType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleWorkstationType;
        private static readonly System.IntPtr NativeFieldInfoPtr_JewelCraftingStationType;
        private static readonly System.IntPtr NativeFieldInfoPtr_StationServantsType;
        private static readonly System.IntPtr NativeFieldInfoPtr_JumpFromCliffsTravelBuffType;
        private static readonly System.IntPtr NativeFieldInfoPtr_DestroyAfterDurationType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Script_Wounded_DataSharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Script_Siphon_Blood_Buff_DataSharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TravelToTargetType;
        private static readonly System.IntPtr NativeFieldInfoPtr_QueuedWorkstationCraftActionType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_QueuedWorkstationCraftActionType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AbilityCooldownStateType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AbilityStateType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleFloorRoofType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleRoomConnectionType;
        private static readonly System.IntPtr NativeFieldInfoPtr_MountBuffType;
        private static readonly System.IntPtr NativeFieldInfoPtr_RespawnPointType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbBuffType;
        private static readonly System.IntPtr NativeFieldInfoPtr_OffsetTranslationOnSpawnType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ProjectileDestroyDataType;
        private static readonly System.IntPtr NativeFieldInfoPtr_SwapArtWhileRaidedRootType;
        private static readonly System.IntPtr NativeFieldInfoPtr_GeneratedNameType;
        private static readonly System.IntPtr NativeFieldInfoPtr_JewelInstanceType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TravelBuffType;
        private static readonly System.IntPtr NativeFieldInfoPtr_SpiderCocoon_DataSharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_UserOwnerType;
        private static readonly System.IntPtr NativeFieldInfoPtr_UnitSpawnerstationType;
        private static readonly System.IntPtr NativeFieldInfoPtr_RefinementstationRecipesBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_RefinementstationRecipesBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_SpawnedUnitsBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_SpawnedUnitsBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Script_HomingSpell_DataSharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_LegDirection_SharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Forge_SharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_EquippableType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ClanTeamType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ClanMemberStatusType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_ClanMemberStatusType;
        private static readonly System.IntPtr NativeFieldInfoPtr_DashType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleRoomType;
        private static readonly System.IntPtr NativeFieldInfoPtr_InputCommandDataType;
        private static readonly System.IntPtr NativeFieldInfoPtr_InputCommandStateType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Script_BloodAltar_TrackVBloodUnit_SharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ChunkPortalType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupSlotType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TortureType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TargetAoEType;
        private static readonly System.IntPtr NativeFieldInfoPtr_PlayerMapIconType;
        private static readonly System.IntPtr NativeFieldInfoPtr_StartGraveyardMapIconType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TraderType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TradeCostType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_TradeCostType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TradeOutputType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_TradeOutputType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TraderEntryType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_TraderEntryType;
        private static readonly System.IntPtr NativeFieldInfoPtr_RefinementstationType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ServantCoffinstationType;
        private static readonly System.IntPtr NativeFieldInfoPtr_PrisonCellType;
        private static readonly System.IntPtr NativeFieldInfoPtr_PrisonstationType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Script_InspectTarget_DataType;
        private static readonly System.IntPtr NativeFieldInfoPtr_PlaceTilemodelAbilityType;
        private static readonly System.IntPtr NativeFieldInfoPtr_SpawnLocationSelectorType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleBuildingFusedChildrenBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_CastleBuildingFusedChildrenBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ResearchBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_ResearchBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Wallpaper_NotSplitType;
        private static readonly System.IntPtr NativeFieldInfoPtr_DurabilityType;
        private static readonly System.IntPtr NativeFieldInfoPtr_LegendaryItemInstanceType;
        private static readonly System.IntPtr NativeFieldInfoPtr_LegendaryItemSpellModSetComponentType;
        private static readonly System.IntPtr NativeFieldInfoPtr_LightningRodStationType;
        private static readonly System.IntPtr NativeFieldInfoPtr_FadeToBlack_ManualType;
        private static readonly System.IntPtr NativeFieldInfoPtr_NPCServantColorIndexType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ServantConnectedCoffinType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ServantEquipmentType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ServantPowerType;
        private static readonly System.IntPtr NativeFieldInfoPtr_PerksBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_PerksBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupComboStateType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AchievementInProgressElementType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_AchievementInProgressElementType;
        private static readonly System.IntPtr NativeFieldInfoPtr_LastTranslationType;
        private static readonly System.IntPtr NativeFieldInfoPtr_BonfireType;
        private static readonly System.IntPtr NativeFieldInfoPtr_BurnContainerType;
        private static readonly System.IntPtr NativeFieldInfoPtr_VbloodGhostBuff_SharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartType;
        private static readonly System.IntPtr NativeFieldInfoPtr_PylonstationType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ActiveServantMissionType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_ActiveServantMissionType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleMemberNamesType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_CastleMemberNamesType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleTeleporterElementType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_CastleTeleporterElementType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Restricted_InventoryBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_Restricted_InventoryBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeathPvPTimerType;
        private static readonly System.IntPtr NativeFieldInfoPtr_FeedableInventoryType;
        private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettingsType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AchievementOwnerType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ControllerType;
        private static readonly System.IntPtr NativeFieldInfoPtr_EmoterType;
        private static readonly System.IntPtr NativeFieldInfoPtr_InputCommandDataProxyType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ProgressionMapperType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ShapeshiftType;
        private static readonly System.IntPtr NativeFieldInfoPtr_UserType;
        private static readonly System.IntPtr NativeFieldInfoPtr_UserHeartCountType;
        private static readonly System.IntPtr NativeFieldInfoPtr_AllyPermissionType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_AllyPermissionType;
        private static readonly System.IntPtr NativeFieldInfoPtr_RespawnPointOwnerBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_RespawnPointOwnerBufferType;
        private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedWaypointElementType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_UnlockedWaypointElementType;
        private static readonly System.IntPtr NativeFieldInfoPtr_UserMapZoneElementType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_UserMapZoneElementType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TeleportBuffType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Script_SetFlyingHeightVision_Buff_DataSharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_TimeScaleType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugLogsType;
        private static readonly System.IntPtr NativeFieldInfoPtr_StoredConsumeCountType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Script_CurseAreaDebuff_DataSharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ServerTimeType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleBuildingFusedChildType;
        private static readonly System.IntPtr NativeFieldInfoPtr_VBloodAbilityReplaceBuffType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleTerritoryDecayType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_CastleTerritoryDecayType;
        private static readonly System.IntPtr NativeFieldInfoPtr_CastleTerritoryOccupantType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Snapshot_CastleTerritoryOccupantType;
        private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSleepingBuffType;
        private static readonly System.IntPtr NativeFieldInfoPtr_Script_DamageZone_SingleTarget_SharedType;
        private static readonly System.IntPtr NativeFieldInfoPtr_SalvagestationType;
        private static readonly System.IntPtr NativeFieldInfoPtr_DayNightCycleType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingCombatTextMessageType;
        private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewDataType;
        private static readonly System.IntPtr NativeFieldInfoPtr_StoredBloodType;
        [FieldOffset(0)]
        public ComponentTypeHandle<PrefabGUID> PrefabGUIDType;
        [FieldOffset(32)]
        public ComponentTypeHandle<NetworkedSpawnChainChild> NetworkedSpawnChainChildType;
        [FieldOffset(64)]
        public ComponentTypeHandle<StaticTransformCompatible> StaticTransformCompatibleType;
        [FieldOffset(96)]
        public ComponentTypeHandle<Team> TeamType;
        [FieldOffset(128)]
        public ComponentTypeHandle<TileModel> TileModelType;
        [FieldOffset(160)]
        public BufferTypeHandle<CastleBuildingAttachedChildrenBuffer> CastleBuildingAttachedChildrenBufferType;
        [FieldOffset(200)]
        public BufferTypeHandle<Snapshot_CastleBuildingAttachedChildrenBuffer> Snapshot_CastleBuildingAttachedChildrenBufferType;
        [FieldOffset(240)]
        public ComponentTypeHandle<Buff> BuffType;
        [FieldOffset(272)]
        public ComponentTypeHandle<EntityCreator> EntityCreatorType;
        [FieldOffset(304)]
        public ComponentTypeHandle<EntityOwner> EntityOwnerType;
        [FieldOffset(336)]
        public ComponentTypeHandle<Script_GarlicAreaDebuff_DataShared> Script_GarlicAreaDebuff_DataSharedType;
        [FieldOffset(368)]
        public ComponentTypeHandle<AbilityBar_Shared> AbilityBar_SharedType;
        [FieldOffset(400)]
        public ComponentTypeHandle<BagHolder> BagHolderType;
        [FieldOffset(432)]
        public ComponentTypeHandle<Blood> BloodType;
        [FieldOffset(464)]
        public ComponentTypeHandle<BuffableFlagState> BuffableFlagStateType;
        [FieldOffset(496)]
        public ComponentTypeHandle<CanFly> CanFlyType;
        [FieldOffset(528)]
        public ComponentTypeHandle<CharacterVoiceActivity> CharacterVoiceActivityType;
        [FieldOffset(560)]
        public ComponentTypeHandle<CombatMusicListener_Shared> CombatMusicListener_SharedType;
        [FieldOffset(592)]
        public ComponentTypeHandle<CustomizationFeatures> CustomizationFeaturesType;
        [FieldOffset(624)]
        public ComponentTypeHandle<DeathRagdollForce> DeathRagdollForceType;
        [FieldOffset(656)]
        public ComponentTypeHandle<DynamicCollision> DynamicCollisionType;
        [FieldOffset(688)]
        public ComponentTypeHandle<Energy> EnergyType;
        [FieldOffset(720)]
        public ComponentTypeHandle<Equipment> EquipmentType;
        [FieldOffset(752)]
        public ComponentTypeHandle<FallToHeight> FallToHeightType;
        [FieldOffset(784)]
        public ComponentTypeHandle<Health> HealthType;
        [FieldOffset(816)]
        public ComponentTypeHandle<Height> HeightType;
        [FieldOffset(848)]
        public ComponentTypeHandle<HybridModelSeed> HybridModelSeedType;
        [FieldOffset(880)]
        public ComponentTypeHandle<InteractedUpon> InteractedUponType;
        [FieldOffset(912)]
        public ComponentTypeHandle<IsSpellControlled> IsSpellControlledType;
        [FieldOffset(944)]
        public ComponentTypeHandle<LifeLeech> LifeLeechType;
        [FieldOffset(976)]
        public ComponentTypeHandle<Mounter> MounterType;
        [FieldOffset(1008)]
        public ComponentTypeHandle<Movement> MovementType;
        [FieldOffset(1040)]
        public ComponentTypeHandle<NetworkInterpolated_Shared> NetworkInterpolated_SharedType;
        [FieldOffset(1072)]
        public ComponentTypeHandle<PlayerCharacter> PlayerCharacterType;
        [FieldOffset(1104)]
        public ComponentTypeHandle<RespawnCharacter> RespawnCharacterType;
        [FieldOffset(1136)]
        public ComponentTypeHandle<Stealthable> StealthableType;
        [FieldOffset(1168)]
        public ComponentTypeHandle<TakeDamageInSun> TakeDamageInSunType;
        [FieldOffset(1200)]
        public ComponentTypeHandle<TargetDirection> TargetDirectionType;
        [FieldOffset(1232)]
        public ComponentTypeHandle<TravelToTargetRadius> TravelToTargetRadiusType;
        [FieldOffset(1264)]
        public ComponentTypeHandle<UnitStats> UnitStatsType;
        [FieldOffset(1296)]
        public ComponentTypeHandle<Vision> VisionType;
        [FieldOffset(1328)]
        public BufferTypeHandle<FollowerBuffer> FollowerBufferType;
        [FieldOffset(1368)]
        public BufferTypeHandle<Snapshot_FollowerBuffer> Snapshot_FollowerBufferType;
        [FieldOffset(1408)]
        public BufferTypeHandle<InventoryInstanceElement> InventoryInstanceElementType;
        [FieldOffset(1448)]
        public BufferTypeHandle<Snapshot_InventoryInstanceElement> Snapshot_InventoryInstanceElementType;
        [FieldOffset(1488)]
        public ComponentTypeHandle<CastleHeartConnection> CastleHeartConnectionType;
        [FieldOffset(1520)]
        public ComponentTypeHandle<CreatedTime> CreatedTimeType;
        [FieldOffset(1552)]
        public ComponentTypeHandle<DismantleDestroyData> DismantleDestroyDataType;
        [FieldOffset(1584)]
        public ComponentTypeHandle<EditableTileModel> EditableTileModelType;
        [FieldOffset(1616)]
        public ComponentTypeHandle<Wallpaper_FourSplits> Wallpaper_FourSplitsType;
        [FieldOffset(1648)]
        public BufferTypeHandle<CastleBuildingAttachToParentsBuffer> CastleBuildingAttachToParentsBufferType;
        [FieldOffset(1688)]
        public BufferTypeHandle<Snapshot_CastleBuildingAttachToParentsBuffer> Snapshot_CastleBuildingAttachToParentsBufferType;
        [FieldOffset(1728)]
        public ComponentTypeHandle<CastleRoofOrnaments> CastleRoofOrnamentsType;
        [FieldOffset(1760)]
        public ComponentTypeHandle<LifeTime> LifeTimeType;
        [FieldOffset(1792)]
        public ComponentTypeHandle<SpawnSequenceForEntity> SpawnSequenceForEntityType;
        [FieldOffset(1824)]
        public ComponentTypeHandle<SpellMovement> SpellMovementType;
        [FieldOffset(1856)]
        public ComponentTypeHandle<AggroConsumer> AggroConsumerType;
        [FieldOffset(1888)]
        public ComponentTypeHandle<AiMove_Shared> AiMove_SharedType;
        [FieldOffset(1920)]
        public ComponentTypeHandle<BloodConsumeSource> BloodConsumeSourceType;
        [FieldOffset(1952)]
        public ComponentTypeHandle<UnitLevel> UnitLevelType;
        [FieldOffset(1984)]
        public ComponentTypeHandle<PlacementDestroyData> PlacementDestroyDataType;
        [FieldOffset(2016)]
        public ComponentTypeHandle<Wallpaper_TwoSplits> Wallpaper_TwoSplitsType;
        [FieldOffset(2048)]
        public ComponentTypeHandle<Door> DoorType;
        [FieldOffset(2080)]
        public ComponentTypeHandle<Translation> TranslationType;
        [FieldOffset(2112)]
        public ComponentTypeHandle<AbilityOwner> AbilityOwnerType;
        [FieldOffset(2144)]
        public ComponentTypeHandle<Rotation> RotationType;
        [FieldOffset(2176)]
        public ComponentTypeHandle<DyeableCastleObject> DyeableCastleObjectType;
        [FieldOffset(2208)]
        public ComponentTypeHandle<ClanInviteRequest_Shared> ClanInviteRequest_SharedType;
        [FieldOffset(2240)]
        public ComponentTypeHandle<Mountable> MountableType;
        [FieldOffset(2272)]
        public ComponentTypeHandle<NameableInteractable> NameableInteractableType;
        [FieldOffset(2304)]
        public ComponentTypeHandle<SaddleBearer> SaddleBearerType;
        [FieldOffset(2336)]
        public ComponentTypeHandle<AbilityGroupState> AbilityGroupStateType;
        [FieldOffset(2368)]
        public ComponentTypeHandle<AbilitySpellModItem> AbilitySpellModItemType;
        [FieldOffset(2400)]
        public ComponentTypeHandle<SpellModSetComponent> SpellModSetComponentType;
        [FieldOffset(2432)]
        public BufferTypeHandle<AbilityStateBuffer> AbilityStateBufferType;
        [FieldOffset(2472)]
        public BufferTypeHandle<Snapshot_AbilityStateBuffer> Snapshot_AbilityStateBufferType;
        [FieldOffset(2512)]
        public ComponentTypeHandle<AbilityChargesState> AbilityChargesStateType;
        [FieldOffset(2544)]
        public ComponentTypeHandle<AbilityTarget> AbilityTargetType;
        [FieldOffset(2576)]
        public ComponentTypeHandle<SpellTarget> SpellTargetType;
        [FieldOffset(2608)]
        public ComponentTypeHandle<RotateOverTimeData> RotateOverTimeDataType;
        [FieldOffset(2640)]
        public ComponentTypeHandle<ProfessorCoilBeam_State_Shared> ProfessorCoilBeam_State_SharedType;
        [FieldOffset(2672)]
        public BufferTypeHandle<InventoryBuffer> InventoryBufferType;
        [FieldOffset(2712)]
        public BufferTypeHandle<Snapshot_InventoryBuffer> Snapshot_InventoryBufferType;
        [FieldOffset(2752)]
        public ComponentTypeHandle<MapIconPosition> MapIconPositionType;
        [FieldOffset(2784)]
        public ComponentTypeHandle<MapIconTargetEntity> MapIconTargetEntityType;
        [FieldOffset(2816)]
        public ComponentTypeHandle<WaypointMapIcon> WaypointMapIconType;
        [FieldOffset(2848)]
        public ComponentTypeHandle<CastleWorkstation> CastleWorkstationType;
        [FieldOffset(2880)]
        public ComponentTypeHandle<JewelCraftingStation> JewelCraftingStationType;
        [FieldOffset(2912)]
        public ComponentTypeHandle<StationServants> StationServantsType;
        [FieldOffset(2944)]
        public ComponentTypeHandle<JumpFromCliffsTravelBuff> JumpFromCliffsTravelBuffType;
        [FieldOffset(2976)]
        public ComponentTypeHandle<DestroyAfterDuration> DestroyAfterDurationType;
        [FieldOffset(3008)]
        public ComponentTypeHandle<Script_Wounded_DataShared> Script_Wounded_DataSharedType;
        [FieldOffset(3040)]
        public ComponentTypeHandle<Script_Siphon_Blood_Buff_DataShared> Script_Siphon_Blood_Buff_DataSharedType;
        [FieldOffset(3072)]
        public ComponentTypeHandle<TravelToTarget> TravelToTargetType;
        [FieldOffset(3104)]
        public BufferTypeHandle<QueuedWorkstationCraftAction> QueuedWorkstationCraftActionType;
        [FieldOffset(3144)]
        public BufferTypeHandle<Snapshot_QueuedWorkstationCraftAction> Snapshot_QueuedWorkstationCraftActionType;
        [FieldOffset(3184)]
        public ComponentTypeHandle<AbilityCooldownState> AbilityCooldownStateType;
        [FieldOffset(3216)]
        public ComponentTypeHandle<AbilityState> AbilityStateType;
        [FieldOffset(3248)]
        public ComponentTypeHandle<CastleFloorRoof> CastleFloorRoofType;
        [FieldOffset(3280)]
        public ComponentTypeHandle<CastleRoomConnection> CastleRoomConnectionType;
        [FieldOffset(3312)]
        public ComponentTypeHandle<MountBuff> MountBuffType;
        [FieldOffset(3344)]
        public ComponentTypeHandle<RespawnPoint> RespawnPointType;
        [FieldOffset(3376)]
        public ComponentTypeHandle<AbsorbBuff> AbsorbBuffType;
        [FieldOffset(3408)]
        public ComponentTypeHandle<OffsetTranslationOnSpawn> OffsetTranslationOnSpawnType;
        [FieldOffset(3440)]
        public ComponentTypeHandle<ProjectileDestroyData> ProjectileDestroyDataType;
        [FieldOffset(3472)]
        public ComponentTypeHandle<SwapArtWhileRaidedRoot> SwapArtWhileRaidedRootType;
        [FieldOffset(3504)]
        public ComponentTypeHandle<GeneratedName> GeneratedNameType;
        [FieldOffset(3536)]
        public ComponentTypeHandle<JewelInstance> JewelInstanceType;
        [FieldOffset(3568)]
        public ComponentTypeHandle<TravelBuff> TravelBuffType;
        [FieldOffset(3600)]
        public ComponentTypeHandle<SpiderCocoon_DataShared> SpiderCocoon_DataSharedType;
        [FieldOffset(3632)]
        public ComponentTypeHandle<UserOwner> UserOwnerType;
        [FieldOffset(3664)]
        public ComponentTypeHandle<UnitSpawnerstation> UnitSpawnerstationType;
        [FieldOffset(3696)]
        public BufferTypeHandle<RefinementstationRecipesBuffer> RefinementstationRecipesBufferType;
        [FieldOffset(3736)]
        public BufferTypeHandle<Snapshot_RefinementstationRecipesBuffer> Snapshot_RefinementstationRecipesBufferType;
        [FieldOffset(3776)]
        public BufferTypeHandle<SpawnedUnitsBuffer> SpawnedUnitsBufferType;
        [FieldOffset(3816)]
        public BufferTypeHandle<Snapshot_SpawnedUnitsBuffer> Snapshot_SpawnedUnitsBufferType;
        [FieldOffset(3856)]
        public ComponentTypeHandle<Script_HomingSpell_DataShared> Script_HomingSpell_DataSharedType;
        [FieldOffset(3888)]
        public ComponentTypeHandle<LegDirection_Shared> LegDirection_SharedType;
        [FieldOffset(3920)]
        public ComponentTypeHandle<Forge_Shared> Forge_SharedType;
        [FieldOffset(3952)]
        public ComponentTypeHandle<Equippable> EquippableType;
        [FieldOffset(3984)]
        public ComponentTypeHandle<ClanTeam> ClanTeamType;
        [FieldOffset(4016)]
        public BufferTypeHandle<ClanMemberStatus> ClanMemberStatusType;
        [FieldOffset(4056)]
        public BufferTypeHandle<Snapshot_ClanMemberStatus> Snapshot_ClanMemberStatusType;
        [FieldOffset(4096)]
        public ComponentTypeHandle<Dash> DashType;
        [FieldOffset(4128)]
        public ComponentTypeHandle<CastleRoom> CastleRoomType;
        [FieldOffset(4160)]
        public ComponentTypeHandle<InputCommandData> InputCommandDataType;
        [FieldOffset(4192)]
        public ComponentTypeHandle<InputCommandState> InputCommandStateType;
        [FieldOffset(4224)]
        public ComponentTypeHandle<Script_BloodAltar_TrackVBloodUnit_Shared> Script_BloodAltar_TrackVBloodUnit_SharedType;
        [FieldOffset(4256)]
        public ComponentTypeHandle<ChunkPortal> ChunkPortalType;
        [FieldOffset(4288)]
        public ComponentTypeHandle<AbilityGroupSlot> AbilityGroupSlotType;
        [FieldOffset(4320)]
        public ComponentTypeHandle<Torture> TortureType;
        [FieldOffset(4352)]
        public ComponentTypeHandle<TargetAoE> TargetAoEType;
        [FieldOffset(4384)]
        public ComponentTypeHandle<PlayerMapIcon> PlayerMapIconType;
        [FieldOffset(4416)]
        public ComponentTypeHandle<StartGraveyardMapIcon> StartGraveyardMapIconType;
        [FieldOffset(4448)]
        public ComponentTypeHandle<Trader> TraderType;
        [FieldOffset(4480)]
        public BufferTypeHandle<TradeCost> TradeCostType;
        [FieldOffset(4520)]
        public BufferTypeHandle<Snapshot_TradeCost> Snapshot_TradeCostType;
        [FieldOffset(4560)]
        public BufferTypeHandle<TradeOutput> TradeOutputType;
        [FieldOffset(4600)]
        public BufferTypeHandle<Snapshot_TradeOutput> Snapshot_TradeOutputType;
        [FieldOffset(4640)]
        public BufferTypeHandle<TraderEntry> TraderEntryType;
        [FieldOffset(4680)]
        public BufferTypeHandle<Snapshot_TraderEntry> Snapshot_TraderEntryType;
        [FieldOffset(4720)]
        public ComponentTypeHandle<Refinementstation> RefinementstationType;
        [FieldOffset(4752)]
        public ComponentTypeHandle<ServantCoffinstation> ServantCoffinstationType;
        [FieldOffset(4784)]
        public ComponentTypeHandle<PrisonCell> PrisonCellType;
        [FieldOffset(4816)]
        public ComponentTypeHandle<Prisonstation> PrisonstationType;
        [FieldOffset(4848)]
        public ComponentTypeHandle<Script_InspectTarget_Data> Script_InspectTarget_DataType;
        [FieldOffset(4880)]
        public ComponentTypeHandle<PlaceTilemodelAbility> PlaceTilemodelAbilityType;
        [FieldOffset(4912)]
        public ComponentTypeHandle<SpawnLocationSelector> SpawnLocationSelectorType;
        [FieldOffset(4944)]
        public BufferTypeHandle<CastleBuildingFusedChildrenBuffer> CastleBuildingFusedChildrenBufferType;
        [FieldOffset(4984)]
        public BufferTypeHandle<Snapshot_CastleBuildingFusedChildrenBuffer> Snapshot_CastleBuildingFusedChildrenBufferType;
        [FieldOffset(5024)]
        public BufferTypeHandle<ResearchBuffer> ResearchBufferType;
        [FieldOffset(5064)]
        public BufferTypeHandle<Snapshot_ResearchBuffer> Snapshot_ResearchBufferType;
        [FieldOffset(5104)]
        public ComponentTypeHandle<Wallpaper_NotSplit> Wallpaper_NotSplitType;
        [FieldOffset(5136)]
        public ComponentTypeHandle<Durability> DurabilityType;
        [FieldOffset(5168)]
        public ComponentTypeHandle<LegendaryItemInstance> LegendaryItemInstanceType;
        [FieldOffset(5200)]
        public ComponentTypeHandle<LegendaryItemSpellModSetComponent> LegendaryItemSpellModSetComponentType;
        [FieldOffset(5232)]
        public ComponentTypeHandle<LightningRodStation> LightningRodStationType;
        [FieldOffset(5264)]
        public ComponentTypeHandle<FadeToBlack_Manual> FadeToBlack_ManualType;
        [FieldOffset(5296)]
        public ComponentTypeHandle<NPCServantColorIndex> NPCServantColorIndexType;
        [FieldOffset(5328)]
        public ComponentTypeHandle<ServantConnectedCoffin> ServantConnectedCoffinType;
        [FieldOffset(5360)]
        public ComponentTypeHandle<ServantEquipment> ServantEquipmentType;
        [FieldOffset(5392)]
        public ComponentTypeHandle<ServantPower> ServantPowerType;
        [FieldOffset(5424)]
        public BufferTypeHandle<PerksBuffer> PerksBufferType;
        [FieldOffset(5464)]
        public BufferTypeHandle<Snapshot_PerksBuffer> Snapshot_PerksBufferType;
        [FieldOffset(5504)]
        public ComponentTypeHandle<AbilityGroupComboState> AbilityGroupComboStateType;
        [FieldOffset(5536)]
        public BufferTypeHandle<AchievementInProgressElement> AchievementInProgressElementType;
        [FieldOffset(5576)]
        public BufferTypeHandle<Snapshot_AchievementInProgressElement> Snapshot_AchievementInProgressElementType;
        [FieldOffset(5616)]
        public ComponentTypeHandle<LastTranslation> LastTranslationType;
        [FieldOffset(5648)]
        public ComponentTypeHandle<Bonfire> BonfireType;
        [FieldOffset(5680)]
        public ComponentTypeHandle<BurnContainer> BurnContainerType;
        [FieldOffset(5712)]
        public ComponentTypeHandle<VbloodGhostBuff_Shared> VbloodGhostBuff_SharedType;
        [FieldOffset(5744)]
        public ComponentTypeHandle<CastleHeart> CastleHeartType;
        [FieldOffset(5776)]
        public ComponentTypeHandle<Pylonstation> PylonstationType;
        [FieldOffset(5808)]
        public BufferTypeHandle<ActiveServantMission> ActiveServantMissionType;
        [FieldOffset(5848)]
        public BufferTypeHandle<Snapshot_ActiveServantMission> Snapshot_ActiveServantMissionType;
        [FieldOffset(5888)]
        public BufferTypeHandle<CastleMemberNames> CastleMemberNamesType;
        [FieldOffset(5928)]
        public BufferTypeHandle<Snapshot_CastleMemberNames> Snapshot_CastleMemberNamesType;
        [FieldOffset(5968)]
        public BufferTypeHandle<CastleTeleporterElement> CastleTeleporterElementType;
        [FieldOffset(6008)]
        public BufferTypeHandle<Snapshot_CastleTeleporterElement> Snapshot_CastleTeleporterElementType;
        [FieldOffset(6048)]
        public BufferTypeHandle<Restricted_InventoryBuffer> Restricted_InventoryBufferType;
        [FieldOffset(6088)]
        public BufferTypeHandle<Snapshot_Restricted_InventoryBuffer> Snapshot_Restricted_InventoryBufferType;
        [FieldOffset(6128)]
        public ComponentTypeHandle<DeathPvPTimer> DeathPvPTimerType;
        [FieldOffset(6160)]
        public ComponentTypeHandle<FeedableInventory> FeedableInventoryType;
        [FieldOffset(6192)]
        public ComponentTypeHandle<SyncedServerDebugSettings> SyncedServerDebugSettingsType;
        [FieldOffset(6224)]
        public ComponentTypeHandle<AchievementOwner> AchievementOwnerType;
        [FieldOffset(6256)]
        public ComponentTypeHandle<Controller> ControllerType;
        [FieldOffset(6288)]
        public ComponentTypeHandle<Emoter> EmoterType;
        [FieldOffset(6320)]
        public ComponentTypeHandle<InputCommandDataProxy> InputCommandDataProxyType;
        [FieldOffset(6352)]
        public ComponentTypeHandle<ProgressionMapper> ProgressionMapperType;
        [FieldOffset(6384)]
        public ComponentTypeHandle<Shapeshift> ShapeshiftType;
        [FieldOffset(6416)]
        public ComponentTypeHandle<User> UserType;
        [FieldOffset(6448)]
        public ComponentTypeHandle<UserHeartCount> UserHeartCountType;
        [FieldOffset(6480)]
        public BufferTypeHandle<AllyPermission> AllyPermissionType;
        [FieldOffset(6520)]
        public BufferTypeHandle<Snapshot_AllyPermission> Snapshot_AllyPermissionType;
        [FieldOffset(6560)]
        public BufferTypeHandle<RespawnPointOwnerBuffer> RespawnPointOwnerBufferType;
        [FieldOffset(6600)]
        public BufferTypeHandle<Snapshot_RespawnPointOwnerBuffer> Snapshot_RespawnPointOwnerBufferType;
        [FieldOffset(6640)]
        public BufferTypeHandle<UnlockedWaypointElement> UnlockedWaypointElementType;
        [FieldOffset(6680)]
        public BufferTypeHandle<Snapshot_UnlockedWaypointElement> Snapshot_UnlockedWaypointElementType;
        [FieldOffset(6720)]
        public BufferTypeHandle<UserMapZoneElement> UserMapZoneElementType;
        [FieldOffset(6760)]
        public BufferTypeHandle<Snapshot_UserMapZoneElement> Snapshot_UserMapZoneElementType;
        [FieldOffset(6800)]
        public ComponentTypeHandle<TeleportBuff> TeleportBuffType;
        [FieldOffset(6832)]
        public ComponentTypeHandle<Script_SetFlyingHeightVision_Buff_DataShared> Script_SetFlyingHeightVision_Buff_DataSharedType;
        [FieldOffset(6864)]
        public ComponentTypeHandle<TimeScale> TimeScaleType;
        [FieldOffset(6896)]
        public ComponentTypeHandle<ServerDebugLogs> ServerDebugLogsType;
        [FieldOffset(6928)]
        public ComponentTypeHandle<StoredConsumeCount> StoredConsumeCountType;
        [FieldOffset(6960)]
        public ComponentTypeHandle<Script_CurseAreaDebuff_DataShared> Script_CurseAreaDebuff_DataSharedType;
        [FieldOffset(6992)]
        public ComponentTypeHandle<ServerTime> ServerTimeType;
        [FieldOffset(7024)]
        public ComponentTypeHandle<CastleBuildingFusedChild> CastleBuildingFusedChildType;
        [FieldOffset(7056)]
        public ComponentTypeHandle<VBloodAbilityReplaceBuff> VBloodAbilityReplaceBuffType;
        [FieldOffset(7088)]
        public BufferTypeHandle<CastleTerritoryDecay> CastleTerritoryDecayType;
        [FieldOffset(7128)]
        public BufferTypeHandle<Snapshot_CastleTerritoryDecay> Snapshot_CastleTerritoryDecayType;
        [FieldOffset(7168)]
        public BufferTypeHandle<CastleTerritoryOccupant> CastleTerritoryOccupantType;
        [FieldOffset(7208)]
        public BufferTypeHandle<Snapshot_CastleTerritoryOccupant> Snapshot_CastleTerritoryOccupantType;
        [FieldOffset(7248)]
        public ComponentTypeHandle<SpawnSleepingBuff> SpawnSleepingBuffType;
        [FieldOffset(7280)]
        public ComponentTypeHandle<Script_DamageZone_SingleTarget_Shared> Script_DamageZone_SingleTarget_SharedType;
        [FieldOffset(7312)]
        public ComponentTypeHandle<Salvagestation> SalvagestationType;
        [FieldOffset(7344)]
        public ComponentTypeHandle<DayNightCycle> DayNightCycleType;
        [FieldOffset(7376)]
        public ComponentTypeHandle<ScrollingCombatTextMessage> ScrollingCombatTextMessageType;
        [FieldOffset(7408)]
        public ComponentTypeHandle<ServerDebugViewData> ServerDebugViewDataType;
        [FieldOffset(7440)]
        public ComponentTypeHandle<StoredBlood> StoredBloodType;

        static JobParams()
        {
          Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob>.NativeClassPtr, nameof (JobParams));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr);
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_PrefabGUIDType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (PrefabGUIDType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_NetworkedSpawnChainChildType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (NetworkedSpawnChainChildType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_StaticTransformCompatibleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (StaticTransformCompatibleType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TeamType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TeamType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TileModelType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TileModelType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleBuildingAttachedChildrenBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleBuildingAttachedChildrenBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_CastleBuildingAttachedChildrenBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_CastleBuildingAttachedChildrenBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_BuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (BuffType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_EntityCreatorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (EntityCreatorType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_EntityOwnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (EntityOwnerType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Script_GarlicAreaDebuff_DataSharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Script_GarlicAreaDebuff_DataSharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AbilityBar_SharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AbilityBar_SharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_BagHolderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (BagHolderType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (BloodType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_BuffableFlagStateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (BuffableFlagStateType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CanFlyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CanFlyType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CharacterVoiceActivityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CharacterVoiceActivityType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CombatMusicListener_SharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CombatMusicListener_SharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CustomizationFeaturesType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CustomizationFeaturesType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_DeathRagdollForceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (DeathRagdollForceType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_DynamicCollisionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (DynamicCollisionType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_EnergyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (EnergyType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_EquipmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (EquipmentType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_FallToHeightType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (FallToHeightType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_HealthType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (HealthType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_HeightType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (HeightType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_HybridModelSeedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (HybridModelSeedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_InteractedUponType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (InteractedUponType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_IsSpellControlledType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (IsSpellControlledType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_LifeLeechType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (LifeLeechType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_MounterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (MounterType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_MovementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (MovementType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_NetworkInterpolated_SharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (NetworkInterpolated_SharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_PlayerCharacterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (PlayerCharacterType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_RespawnCharacterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (RespawnCharacterType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_StealthableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (StealthableType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TakeDamageInSunType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TakeDamageInSunType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TargetDirectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TargetDirectionType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TravelToTargetRadiusType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TravelToTargetRadiusType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_UnitStatsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (UnitStatsType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_VisionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (VisionType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_FollowerBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (FollowerBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_FollowerBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_FollowerBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_InventoryInstanceElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (InventoryInstanceElementType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_InventoryInstanceElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_InventoryInstanceElementType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleHeartConnectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleHeartConnectionType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CreatedTimeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CreatedTimeType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_DismantleDestroyDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (DismantleDestroyDataType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_EditableTileModelType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (EditableTileModelType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Wallpaper_FourSplitsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Wallpaper_FourSplitsType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleBuildingAttachToParentsBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleBuildingAttachToParentsBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_CastleBuildingAttachToParentsBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_CastleBuildingAttachToParentsBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleRoofOrnamentsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleRoofOrnamentsType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_LifeTimeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (LifeTimeType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_SpawnSequenceForEntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (SpawnSequenceForEntityType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_SpellMovementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (SpellMovementType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AggroConsumerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AggroConsumerType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AiMove_SharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AiMove_SharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_BloodConsumeSourceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (BloodConsumeSourceType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_UnitLevelType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (UnitLevelType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_PlacementDestroyDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (PlacementDestroyDataType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Wallpaper_TwoSplitsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Wallpaper_TwoSplitsType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_DoorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (DoorType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TranslationType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AbilityOwnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AbilityOwnerType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_RotationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (RotationType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_DyeableCastleObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (DyeableCastleObjectType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ClanInviteRequest_SharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ClanInviteRequest_SharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_MountableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (MountableType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_NameableInteractableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (NameableInteractableType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_SaddleBearerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (SaddleBearerType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AbilityGroupStateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AbilityGroupStateType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AbilitySpellModItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AbilitySpellModItemType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_SpellModSetComponentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (SpellModSetComponentType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AbilityStateBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AbilityStateBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_AbilityStateBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_AbilityStateBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AbilityChargesStateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AbilityChargesStateType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AbilityTargetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AbilityTargetType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_SpellTargetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (SpellTargetType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_RotateOverTimeDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (RotateOverTimeDataType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ProfessorCoilBeam_State_SharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ProfessorCoilBeam_State_SharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_InventoryBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (InventoryBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_InventoryBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_InventoryBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_MapIconPositionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (MapIconPositionType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_MapIconTargetEntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (MapIconTargetEntityType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_WaypointMapIconType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (WaypointMapIconType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleWorkstationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleWorkstationType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_JewelCraftingStationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (JewelCraftingStationType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_StationServantsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (StationServantsType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_JumpFromCliffsTravelBuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (JumpFromCliffsTravelBuffType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_DestroyAfterDurationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (DestroyAfterDurationType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Script_Wounded_DataSharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Script_Wounded_DataSharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Script_Siphon_Blood_Buff_DataSharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Script_Siphon_Blood_Buff_DataSharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TravelToTargetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TravelToTargetType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_QueuedWorkstationCraftActionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (QueuedWorkstationCraftActionType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_QueuedWorkstationCraftActionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_QueuedWorkstationCraftActionType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AbilityCooldownStateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AbilityCooldownStateType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AbilityStateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AbilityStateType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleFloorRoofType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleFloorRoofType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleRoomConnectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleRoomConnectionType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_MountBuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (MountBuffType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_RespawnPointType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (RespawnPointType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AbsorbBuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AbsorbBuffType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_OffsetTranslationOnSpawnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (OffsetTranslationOnSpawnType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ProjectileDestroyDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ProjectileDestroyDataType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_SwapArtWhileRaidedRootType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (SwapArtWhileRaidedRootType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_GeneratedNameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (GeneratedNameType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_JewelInstanceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (JewelInstanceType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TravelBuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TravelBuffType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_SpiderCocoon_DataSharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (SpiderCocoon_DataSharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_UserOwnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (UserOwnerType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_UnitSpawnerstationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (UnitSpawnerstationType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_RefinementstationRecipesBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (RefinementstationRecipesBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_RefinementstationRecipesBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_RefinementstationRecipesBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_SpawnedUnitsBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (SpawnedUnitsBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_SpawnedUnitsBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_SpawnedUnitsBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Script_HomingSpell_DataSharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Script_HomingSpell_DataSharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_LegDirection_SharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (LegDirection_SharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Forge_SharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Forge_SharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_EquippableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (EquippableType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ClanTeamType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ClanTeamType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ClanMemberStatusType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ClanMemberStatusType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_ClanMemberStatusType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_ClanMemberStatusType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_DashType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (DashType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleRoomType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleRoomType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_InputCommandDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (InputCommandDataType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_InputCommandStateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (InputCommandStateType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Script_BloodAltar_TrackVBloodUnit_SharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Script_BloodAltar_TrackVBloodUnit_SharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ChunkPortalType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ChunkPortalType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AbilityGroupSlotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AbilityGroupSlotType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TortureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TortureType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TargetAoEType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TargetAoEType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_PlayerMapIconType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (PlayerMapIconType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_StartGraveyardMapIconType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (StartGraveyardMapIconType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TraderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TraderType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TradeCostType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TradeCostType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_TradeCostType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_TradeCostType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TradeOutputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TradeOutputType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_TradeOutputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_TradeOutputType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TraderEntryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TraderEntryType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_TraderEntryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_TraderEntryType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_RefinementstationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (RefinementstationType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ServantCoffinstationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ServantCoffinstationType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_PrisonCellType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (PrisonCellType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_PrisonstationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (PrisonstationType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Script_InspectTarget_DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Script_InspectTarget_DataType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_PlaceTilemodelAbilityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (PlaceTilemodelAbilityType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_SpawnLocationSelectorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (SpawnLocationSelectorType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleBuildingFusedChildrenBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleBuildingFusedChildrenBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_CastleBuildingFusedChildrenBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_CastleBuildingFusedChildrenBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ResearchBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ResearchBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_ResearchBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_ResearchBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Wallpaper_NotSplitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Wallpaper_NotSplitType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_DurabilityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (DurabilityType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_LegendaryItemInstanceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (LegendaryItemInstanceType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_LegendaryItemSpellModSetComponentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (LegendaryItemSpellModSetComponentType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_LightningRodStationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (LightningRodStationType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_FadeToBlack_ManualType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (FadeToBlack_ManualType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_NPCServantColorIndexType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (NPCServantColorIndexType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ServantConnectedCoffinType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ServantConnectedCoffinType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ServantEquipmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ServantEquipmentType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ServantPowerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ServantPowerType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_PerksBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (PerksBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_PerksBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_PerksBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AbilityGroupComboStateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AbilityGroupComboStateType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AchievementInProgressElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AchievementInProgressElementType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_AchievementInProgressElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_AchievementInProgressElementType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_LastTranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (LastTranslationType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_BonfireType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (BonfireType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_BurnContainerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (BurnContainerType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_VbloodGhostBuff_SharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (VbloodGhostBuff_SharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleHeartType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleHeartType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_PylonstationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (PylonstationType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ActiveServantMissionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ActiveServantMissionType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_ActiveServantMissionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_ActiveServantMissionType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleMemberNamesType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleMemberNamesType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_CastleMemberNamesType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_CastleMemberNamesType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleTeleporterElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleTeleporterElementType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_CastleTeleporterElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_CastleTeleporterElementType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Restricted_InventoryBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Restricted_InventoryBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_Restricted_InventoryBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_Restricted_InventoryBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_DeathPvPTimerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (DeathPvPTimerType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_FeedableInventoryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (FeedableInventoryType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_SyncedServerDebugSettingsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (SyncedServerDebugSettingsType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AchievementOwnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AchievementOwnerType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ControllerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ControllerType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_EmoterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (EmoterType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_InputCommandDataProxyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (InputCommandDataProxyType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ProgressionMapperType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ProgressionMapperType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ShapeshiftType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ShapeshiftType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_UserType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (UserType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_UserHeartCountType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (UserHeartCountType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_AllyPermissionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (AllyPermissionType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_AllyPermissionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_AllyPermissionType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_RespawnPointOwnerBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (RespawnPointOwnerBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_RespawnPointOwnerBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_RespawnPointOwnerBufferType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_UnlockedWaypointElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (UnlockedWaypointElementType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_UnlockedWaypointElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_UnlockedWaypointElementType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_UserMapZoneElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (UserMapZoneElementType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_UserMapZoneElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_UserMapZoneElementType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TeleportBuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TeleportBuffType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Script_SetFlyingHeightVision_Buff_DataSharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Script_SetFlyingHeightVision_Buff_DataSharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_TimeScaleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (TimeScaleType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ServerDebugLogsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ServerDebugLogsType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_StoredConsumeCountType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (StoredConsumeCountType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Script_CurseAreaDebuff_DataSharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Script_CurseAreaDebuff_DataSharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ServerTimeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ServerTimeType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleBuildingFusedChildType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleBuildingFusedChildType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_VBloodAbilityReplaceBuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (VBloodAbilityReplaceBuffType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleTerritoryDecayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleTerritoryDecayType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_CastleTerritoryDecayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_CastleTerritoryDecayType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_CastleTerritoryOccupantType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (CastleTerritoryOccupantType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Snapshot_CastleTerritoryOccupantType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Snapshot_CastleTerritoryOccupantType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_SpawnSleepingBuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (SpawnSleepingBuffType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_Script_DamageZone_SingleTarget_SharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (Script_DamageZone_SingleTarget_SharedType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_SalvagestationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (SalvagestationType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_DayNightCycleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (DayNightCycleType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ScrollingCombatTextMessageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ScrollingCombatTextMessageType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_ServerDebugViewDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (ServerDebugViewDataType));
          StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams.NativeFieldInfoPtr_StoredBloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, nameof (StoredBloodType));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StartValueSnapshotsSystem.StartValueSnapshotsJob.JobParams>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }
  }
}
