// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.CopySnapshotsToEntitiesSystem
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  public class CopySnapshotsToEntitiesSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CopySnapshotsFromTheseEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReceivedPrefabReferences;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCopySnapshotsFromTheseEntities_Internal_NativeHashSet_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertReferencesOnDemandForEntities_Private_Void_NativeList_1_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 29043, RefRangeEnd = 29047, XrefRangeStart = 29043, XrefRangeEnd = 29047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeHashSet<Entity> GetCopySnapshotsFromTheseEntities()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.NativeMethodInfoPtr_GetCopySnapshotsFromTheseEntities_Internal_NativeHashSet_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeHashSet<Entity>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501457, XrefRangeEnd = 1501477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CopySnapshotsToEntitiesSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501477, XrefRangeEnd = 1501486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CopySnapshotsToEntitiesSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501486, XrefRangeEnd = 1501520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CopySnapshotsToEntitiesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConvertReferencesOnDemandForEntities(NativeList<PrefabGUID> toConvert)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &toConvert;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.NativeMethodInfoPtr_ConvertReferencesOnDemandForEntities_Private_Void_NativeList_1_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CopySnapshotsToEntitiesSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CopySnapshotsToEntitiesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CopySnapshotsToEntitiesSystem()
    {
      Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (CopySnapshotsToEntitiesSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr);
      CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__CopySnapshotsFromTheseEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr, nameof (_CopySnapshotsFromTheseEntities));
      CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__ReceivedPrefabReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr, nameof (_ReceivedPrefabReferences));
      CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr, nameof (_WorldFrame));
      CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      CopySnapshotsToEntitiesSystem.NativeMethodInfoPtr_GetCopySnapshotsFromTheseEntities_Internal_NativeHashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr, 100663754);
      CopySnapshotsToEntitiesSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr, 100663755);
      CopySnapshotsToEntitiesSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr, 100663756);
      CopySnapshotsToEntitiesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr, 100663757);
      CopySnapshotsToEntitiesSystem.NativeMethodInfoPtr_ConvertReferencesOnDemandForEntities_Private_Void_NativeList_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr, 100663758);
      CopySnapshotsToEntitiesSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr, 100663759);
      CopySnapshotsToEntitiesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr, 100663760);
    }

    public CopySnapshotsToEntitiesSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeHashSet<Entity> _CopySnapshotsFromTheseEntities
    {
      get
      {
        return *(NativeHashSet<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__CopySnapshotsFromTheseEntities));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__CopySnapshotsFromTheseEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<PrefabGUID> _ReceivedPrefabReferences
    {
      get
      {
        return *(NativeList<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__ReceivedPrefabReferences));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__ReceivedPrefabReferences), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<WorldFrame> _WorldFrame
    {
      get
      {
        return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__WorldFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CopySnapshotsToEntitiesSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CopySnapshotsToGameplay
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_SynchronizedEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReceivedPrefabReferences;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunJobForEntity_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acbbdiefgbd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acbbgiidegf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acbdgdebikk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acbfcjichfb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acbhckcfdfd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acbhkjccgdi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acbicfeedbb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acbiddcjjid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acccfjkdigh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acccgefcedb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_accdbefiheb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_accdjiedgfe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_accgciikfbf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_accgiggcif_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acchhgcjcbh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acchibekekj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acciegkehkf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acdccjhicfg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acdehhkijdj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acdfgkkfchc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acdficciidc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acdibbekbkk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acdidhjbjgj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acdjdjkckhd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acdjighgcci_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acdkgjbefjd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acdkkhcbdcg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acecggedbff_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aceegbjekgb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aceehcgeedj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acegbdcgkdf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aceihfcgifd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acekdgegehc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acekjgheehk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acfckgbfifj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acfebiceeh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acfhdekidie_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acfikjcfik_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acgbiiekebj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acgchdfhdbe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acgckficfjg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acgddgdckdd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acgefcgggfi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acgfefhihji_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acggehdijfg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acggfcbekbj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acggkbfbjck_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acghdchgjgf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_achbffjechg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_achbhefgeeh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_achbhhddbh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_achcbdhidik_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_achdjgjdgkk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_achfcefeheb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_achgedhdigf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_achgegcdkcj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_achicekidek_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_achiggdccdc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_achjkedegdi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_achjkicgkif_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aciddedkjj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acidekciged_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acidjkkbgbk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acifkidfebh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acigkbdedfb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acihcehbbb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acihehkdfeh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acihkdjfdkb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aciibbeciec_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acikghjjgki_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acikhjeehkg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acjbgiffidc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acjdegcccg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acjigbfeikj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_acjkcgkfjff_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ackbhgekeci_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ackchfegcjc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ackdkfeghk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ackebkbdbjj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ackffdikde_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ackgdbibjbd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ackifjdcjjd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ackjbcfijee_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ackkecjdkk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adbbickeikd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adbfkibeiid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adbfkjhfcjd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adbgiccjej_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adbhchjbgek_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adbijghdjjj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adbjcebiefe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adbjdjfkiif_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adbjkedbgjg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adbjkhhkffi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adbkdbehhdh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adcbfjighfe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adcdbdebfjg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adcffdijihg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adejkghcfk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adekhbkfjb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adgbkkgkkc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adgcbgkcfb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adjbidcgdh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_adkecehjdk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aebfefikfc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aegjbedggh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aeibfebcie_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aejfcffkde_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_afcdibbdhk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_afdcikchcf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_afdgichhbg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_afdgigchdc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_afejhccjki_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_afgfgihgc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_afghjhgcgk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_afibjfgjj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_afiidbjjg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_afkbfgfhef_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_agcdkcdjfe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_agfgchgici_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aggchckijc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_agghikgigk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aghhkgkfc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_agijkdicg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_agjkgikkig_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_agkckkkggd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ahbgechgbk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ahciehbbdc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ahiggbegei_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ahijjfgjce_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ahkcgijbei_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ahkijdhjcb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aicgdjfcgb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aidbefcifj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aidcegcehg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aiebecdijh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aieefjchbd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aiejbddfde_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aifejkfbkk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aifkcjfiic_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_aigchgfejj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ajcejdgdjc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ajchjhccfg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ajfedjbbig_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ajghhigdb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ajgkhchijb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ajkhbehfkf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_akdddhikjj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_akdhbfiiid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_akfbbffjcg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_akgbiefjbh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_akhbjjbcei_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_akhiekbd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_akidjkegkj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_akjcidekhd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_akjiekjkkh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cbbeifjkdj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cbffeddche_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cbggkebbfk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cbhkgfiiif_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cbjidfdhfg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cbkcbhjiek_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cbkfhfcjb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ccbfibgeci_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cccffebffc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cccggcfdkg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ccekgicgfh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ccfhfbhikj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ccgjgbjcgi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cchfdhghjd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cddckigibk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cdedfgfkdj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cdfdcchhe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cdfibdbkfb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cdfjfbikid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cdgbkkidfd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cdgibkchih_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cdidfjjidb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cdjkcdjcgc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cebdekghcc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ceceehkkdb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cechbcjbje_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cechggbfcg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cechibbibc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cedekbhedh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ceecjebgfd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ceffhbdbf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cegbicbcfg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cegkcgkkgb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ceiggdddik_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cejhdeejck_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cekhfceefg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cfbedkikg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cfbjdedjcj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cfbjghgjgf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cfcfjiceg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cfcjbdhdik_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cfcjgefdjg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cfedcgehh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cfffedbhfg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cfiggjfcfh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cfjbbdjcdi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cfkdeghg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cgbbhfbgbj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cgbeibighh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cgdieefdkk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cghhdebggi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cgighkjefc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cgjchkijib_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_chdckkkgkg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_chedkdbce_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_chhcdcgigb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_chibdbkfde_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_chibgkeeji_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_chiceijbgj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_chiffhjbee_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_chiiihhffh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cichefikeb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cicjgdikig_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cifbcfjkdj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cigfkckdgc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cijeifhgec_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cijijgbkgk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cjbcjhhgke_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cjbjeehdbk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cjdkihjijd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cjfdcbgfgj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cjgbfhfgef_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cjhkjfhhf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cjicjgdfff_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cjjdbgbddi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cjjdkdfkkh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_cjjjckihek_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ckbiikefid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ckeiejdgib_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ckkddehif_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dbbbcebccf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dbedicfecc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dbfehhjdb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dbibcdhcc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dbjjcgeeki_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dcbffdidkk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dcbkfgcjid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dcdjbbkec_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dcebfkhcgc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dcecciefge_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dcehkgkifb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dcfehdgdkj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ddffjifbf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ddikijcge_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_debdghice_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dfcjdjkjk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dfjibkhbh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_dihkeehk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_djigibich_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ebgkehdgb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ecgibfdjb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_edfkjgfch_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ehkcekjii_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_eidhfehik_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_eiehjkdd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ejjgbkdff_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ejkdcifhg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_fbejgkdib_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_fdjggbfcb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_fdkkidgb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_fekcijijf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_fgcbdbbid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_fgfckhdf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_fhcdfebdc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_fhjkfjice_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_fihfdkijh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_fjkikekhi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_fkbkbchgb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_fkedkejgf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_fkfbciibe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_gbchjfieb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_gbibihicb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_geijfbdhc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_gfgdjegbe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_gihjfdefi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_gjgidfgeh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_hbeefgbjc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_hcehhjdfk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_hekdkcdeh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_hfjfeiijk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_hhbehfckd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_hhkbgdice_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_hikdcfgkb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_hkdbgkgik_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ibbddjcfb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ichfccfhh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_idchgghie_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_iddeebfkg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_iddhiekfi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_idjfhgckc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ihbgcbhic_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_iicekghif_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_iifbheddf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_ikejdbedk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_jcdhbjde_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_jceehdeeh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_jchhdjhkg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_jgcekgbii_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_jigekbbhd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_jjjcegjeg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_jkekeckbf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_kbcfjkedc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_kdbikhddc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_kddgijibc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_kdhdheib_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_kfbbiddfg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_kfkchgjdd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_kiighbfgg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshot_kijdhbiid_Private_Void_Entity_0;
      [FieldOffset(0)]
      public int CurrentFrame;
      [FieldOffset(8)]
      public EntityManager EntityManager;
      [FieldOffset(16)]
      public NativeArray<Entity> SynchronizedEntities;
      [FieldOffset(32)]
      public NativeHashMap<NetworkId, Entity> NetworkedIdToEntityMap;
      [FieldOffset(48)]
      public NativeList<PrefabGUID> ReceivedPrefabReferences;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483902, XrefRangeEnd = 1483903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1483910, RefRangeEnd = 1483911, XrefRangeStart = 1483903, XrefRangeEnd = 1483910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void RunJobForEntity(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_RunJobForEntity_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1483953, RefRangeEnd = 1483954, XrefRangeStart = 1483911, XrefRangeEnd = 1483953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acbbdiefgbd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbbdiefgbd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483954, XrefRangeEnd = 1483980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acbbgiidegf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbbgiidegf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483980, XrefRangeEnd = 1484335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acbdgdebikk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbdgdebikk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1484335, XrefRangeEnd = 1484356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acbfcjichfb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbfcjichfb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1484356, XrefRangeEnd = 1484443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acbhckcfdfd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbhckcfdfd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1484443, XrefRangeEnd = 1484523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acbhkjccgdi(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbhkjccgdi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1484523, XrefRangeEnd = 1484544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acbicfeedbb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbicfeedbb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1484544, XrefRangeEnd = 1484563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acbiddcjjid(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbiddcjjid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1484563, XrefRangeEnd = 1484705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acccfjkdigh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acccfjkdigh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1484705, XrefRangeEnd = 1484761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acccgefcedb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acccgefcedb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1484761, XrefRangeEnd = 1484808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_accdbefiheb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_accdbefiheb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1484808, XrefRangeEnd = 1484895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_accdjiedgfe(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_accdjiedgfe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1484895, XrefRangeEnd = 1484946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_accgciikfbf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_accgciikfbf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1484946, XrefRangeEnd = 1484970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_accgiggcif(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_accgiggcif_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1484970, XrefRangeEnd = 1484998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acchhgcjcbh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acchhgcjcbh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1484998, XrefRangeEnd = 1485021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acchibekekj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acchibekekj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485021, XrefRangeEnd = 1485101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acciegkehkf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acciegkehkf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485101, XrefRangeEnd = 1485115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acdccjhicfg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdccjhicfg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485115, XrefRangeEnd = 1485260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acdehhkijdj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdehhkijdj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485260, XrefRangeEnd = 1485330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acdfgkkfchc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdfgkkfchc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485330, XrefRangeEnd = 1485376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acdficciidc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdficciidc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485376, XrefRangeEnd = 1485425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acdibbekbkk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdibbekbkk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485425, XrefRangeEnd = 1485564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acdidhjbjgj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdidhjbjgj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485564, XrefRangeEnd = 1485597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acdjdjkckhd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdjdjkckhd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485597, XrefRangeEnd = 1485617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acdjighgcci(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdjighgcci_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485617, XrefRangeEnd = 1485628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acdkgjbefjd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdkgjbefjd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485628, XrefRangeEnd = 1485671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acdkkhcbdcg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdkkhcbdcg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485671, XrefRangeEnd = 1485692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acecggedbff(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acecggedbff_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485692, XrefRangeEnd = 1485816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aceegbjekgb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aceegbjekgb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485816, XrefRangeEnd = 1485848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aceehcgeedj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aceehcgeedj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485848, XrefRangeEnd = 1485883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acegbdcgkdf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acegbdcgkdf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485883, XrefRangeEnd = 1485924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aceihfcgifd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aceihfcgifd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485924, XrefRangeEnd = 1485947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acekdgegehc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acekdgegehc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485947, XrefRangeEnd = 1485974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acekjgheehk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acekjgheehk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485974, XrefRangeEnd = 1486110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acfckgbfifj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acfckgbfifj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486110, XrefRangeEnd = 1486252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acfebiceeh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acfebiceeh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486252, XrefRangeEnd = 1486286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acfhdekidie(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acfhdekidie_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486286, XrefRangeEnd = 1486306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acfikjcfik(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acfikjcfik_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486306, XrefRangeEnd = 1486332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acgbiiekebj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acgbiiekebj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486332, XrefRangeEnd = 1486376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acgchdfhdbe(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acgchdfhdbe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486376, XrefRangeEnd = 1486516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acgckficfjg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acgckficfjg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486516, XrefRangeEnd = 1486537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acgddgdckdd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acgddgdckdd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486537, XrefRangeEnd = 1486611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acgefcgggfi(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acgefcgggfi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486611, XrefRangeEnd = 1486654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acgfefhihji(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acgfefhihji_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486654, XrefRangeEnd = 1486679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acggehdijfg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acggehdijfg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486679, XrefRangeEnd = 1486705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acggfcbekbj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acggfcbekbj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486705, XrefRangeEnd = 1486816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acggkbfbjck(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acggkbfbjck_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486816, XrefRangeEnd = 1486892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acghdchgjgf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acghdchgjgf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486892, XrefRangeEnd = 1486945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_achbffjechg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achbffjechg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1486945, XrefRangeEnd = 1487030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_achbhefgeeh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achbhefgeeh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487030, XrefRangeEnd = 1487068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_achbhhddbh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achbhhddbh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487068, XrefRangeEnd = 1487097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_achcbdhidik(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achcbdhidik_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487097, XrefRangeEnd = 1487114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_achdjgjdgkk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achdjgjdgkk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487114, XrefRangeEnd = 1487146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_achfcefeheb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achfcefeheb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487146, XrefRangeEnd = 1487180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_achgedhdigf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achgedhdigf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487180, XrefRangeEnd = 1487212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_achgegcdkcj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achgegcdkcj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487212, XrefRangeEnd = 1487302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_achicekidek(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achicekidek_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487302, XrefRangeEnd = 1487319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_achiggdccdc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achiggdccdc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487319, XrefRangeEnd = 1487330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_achjkedegdi(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achjkedegdi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487330, XrefRangeEnd = 1487444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_achjkicgkif(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achjkicgkif_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487444, XrefRangeEnd = 1487467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aciddedkjj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aciddedkjj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487467, XrefRangeEnd = 1487507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acidekciged(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acidekciged_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487507, XrefRangeEnd = 1487547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acidjkkbgbk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acidjkkbgbk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487547, XrefRangeEnd = 1487585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acifkidfebh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acifkidfebh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487585, XrefRangeEnd = 1487624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acigkbdedfb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acigkbdedfb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487624, XrefRangeEnd = 1487648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acihcehbbb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acihcehbbb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487648, XrefRangeEnd = 1487701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acihehkdfeh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acihehkdfeh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487701, XrefRangeEnd = 1487721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acihkdjfdkb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acihkdjfdkb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487721, XrefRangeEnd = 1487741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aciibbeciec(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aciibbeciec_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487741, XrefRangeEnd = 1487761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acikghjjgki(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acikghjjgki_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487761, XrefRangeEnd = 1487796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acikhjeehkg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acikhjeehkg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487796, XrefRangeEnd = 1487853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acjbgiffidc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acjbgiffidc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1487853, XrefRangeEnd = 1488011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acjdegcccg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acjdegcccg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488011, XrefRangeEnd = 1488034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acjigbfeikj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acjigbfeikj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488034, XrefRangeEnd = 1488170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_acjkcgkfjff(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acjkcgkfjff_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488170, XrefRangeEnd = 1488184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ackbhgekeci(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackbhgekeci_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488184, XrefRangeEnd = 1488195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ackchfegcjc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackchfegcjc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488195, XrefRangeEnd = 1488319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ackdkfeghk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackdkfeghk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488319, XrefRangeEnd = 1488331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ackebkbdbjj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackebkbdbjj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488331, XrefRangeEnd = 1488353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ackffdikde(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackffdikde_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488353, XrefRangeEnd = 1488415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ackgdbibjbd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackgdbibjbd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488415, XrefRangeEnd = 1488446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ackifjdcjjd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackifjdcjjd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488446, XrefRangeEnd = 1488472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ackjbcfijee(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackjbcfijee_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488472, XrefRangeEnd = 1488502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ackkecjdkk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackkecjdkk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488502, XrefRangeEnd = 1488516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adbbickeikd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbbickeikd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488516, XrefRangeEnd = 1488545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adbfkibeiid(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbfkibeiid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488545, XrefRangeEnd = 1488559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adbfkjhfcjd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbfkjhfcjd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488559, XrefRangeEnd = 1488585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adbgiccjej(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbgiccjej_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488585, XrefRangeEnd = 1488608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adbhchjbgek(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbhchjbgek_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488608, XrefRangeEnd = 1488626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adbijghdjjj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbijghdjjj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488626, XrefRangeEnd = 1488658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adbjcebiefe(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbjcebiefe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488658, XrefRangeEnd = 1488800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adbjdjfkiif(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbjdjfkiif_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488800, XrefRangeEnd = 1488859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adbjkedbgjg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbjkedbgjg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488859, XrefRangeEnd = 1488915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adbjkhhkffi(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbjkhhkffi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488915, XrefRangeEnd = 1488941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adbkdbehhdh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbkdbehhdh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488941, XrefRangeEnd = 1488979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adcbfjighfe(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adcbfjighfe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1488979, XrefRangeEnd = 1489011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adcdbdebfjg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adcdbdebfjg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489011, XrefRangeEnd = 1489077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adcffdijihg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adcffdijihg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489077, XrefRangeEnd = 1489237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adejkghcfk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adejkghcfk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489237, XrefRangeEnd = 1489254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adekhbkfjb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adekhbkfjb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489254, XrefRangeEnd = 1489277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adgbkkgkkc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adgbkkgkkc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489277, XrefRangeEnd = 1489305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adgcbgkcfb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adgcbgkcfb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489305, XrefRangeEnd = 1489377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adjbidcgdh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adjbidcgdh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489377, XrefRangeEnd = 1489398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_adkecehjdk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adkecehjdk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489398, XrefRangeEnd = 1489430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aebfefikfc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aebfefikfc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489430, XrefRangeEnd = 1489448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aegjbedggh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aegjbedggh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489448, XrefRangeEnd = 1489483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aeibfebcie(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aeibfebcie_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489483, XrefRangeEnd = 1489512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aejfcffkde(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aejfcffkde_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489512, XrefRangeEnd = 1489542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_afcdibbdhk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afcdibbdhk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489542, XrefRangeEnd = 1489681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_afdcikchcf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afdcikchcf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489681, XrefRangeEnd = 1489789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_afdgichhbg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afdgichhbg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489789, XrefRangeEnd = 1489818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_afdgigchdc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afdgigchdc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1489818, XrefRangeEnd = 1490071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_afejhccjki(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afejhccjki_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1490071, XrefRangeEnd = 1490216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_afgfgihgc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afgfgihgc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1490216, XrefRangeEnd = 1490245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_afghjhgcgk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afghjhgcgk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1490245, XrefRangeEnd = 1490342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_afibjfgjj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afibjfgjj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1490342, XrefRangeEnd = 1490484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_afiidbjjg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afiidbjjg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1490484, XrefRangeEnd = 1490625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_afkbfgfhef(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afkbfgfhef_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1490625, XrefRangeEnd = 1490776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_agcdkcdjfe(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_agcdkcdjfe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1490776, XrefRangeEnd = 1490799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_agfgchgici(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_agfgchgici_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1490799, XrefRangeEnd = 1490843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aggchckijc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aggchckijc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1490843, XrefRangeEnd = 1490878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_agghikgigk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_agghikgigk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1490878, XrefRangeEnd = 1490912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aghhkgkfc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aghhkgkfc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1490912, XrefRangeEnd = 1490946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_agijkdicg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_agijkdicg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1490946, XrefRangeEnd = 1490989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_agjkgikkig(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_agjkgikkig_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1490989, XrefRangeEnd = 1491037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_agkckkkggd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_agkckkkggd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491037, XrefRangeEnd = 1491058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ahbgechgbk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ahbgechgbk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491058, XrefRangeEnd = 1491093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ahciehbbdc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ahciehbbdc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491093, XrefRangeEnd = 1491142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ahiggbegei(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ahiggbegei_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491142, XrefRangeEnd = 1491247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ahijjfgjce(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ahijjfgjce_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491247, XrefRangeEnd = 1491261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ahkcgijbei(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ahkcgijbei_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491261, XrefRangeEnd = 1491289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ahkijdhjcb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ahkijdhjcb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491289, XrefRangeEnd = 1491318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aicgdjfcgb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aicgdjfcgb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491318, XrefRangeEnd = 1491463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aidbefcifj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aidbefcifj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491463, XrefRangeEnd = 1491600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aidcegcehg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aidcegcehg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491600, XrefRangeEnd = 1491615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aiebecdijh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aiebecdijh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491615, XrefRangeEnd = 1491751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aieefjchbd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aieefjchbd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491751, XrefRangeEnd = 1491848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aiejbddfde(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aiejbddfde_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491848, XrefRangeEnd = 1491935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aifejkfbkk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aifejkfbkk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491935, XrefRangeEnd = 1491959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aifkcjfiic(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aifkcjfiic_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491959, XrefRangeEnd = 1491997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_aigchgfejj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aigchgfejj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1491997, XrefRangeEnd = 1492028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ajcejdgdjc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ajcejdgdjc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492028, XrefRangeEnd = 1492054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ajchjhccfg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ajchjhccfg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492054, XrefRangeEnd = 1492113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ajfedjbbig(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ajfedjbbig_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492113, XrefRangeEnd = 1492135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ajghhigdb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ajghhigdb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492135, XrefRangeEnd = 1492160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ajgkhchijb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ajgkhchijb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492160, XrefRangeEnd = 1492209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ajkhbehfkf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ajkhbehfkf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492209, XrefRangeEnd = 1492243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_akdddhikjj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akdddhikjj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492243, XrefRangeEnd = 1492272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_akdhbfiiid(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akdhbfiiid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492272, XrefRangeEnd = 1492298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_akfbbffjcg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akfbbffjcg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492298, XrefRangeEnd = 1492328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_akgbiefjbh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akgbiefjbh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492328, XrefRangeEnd = 1492385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_akhbjjbcei(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akhbjjbcei_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492385, XrefRangeEnd = 1492402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_akhiekbd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akhiekbd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492402, XrefRangeEnd = 1492429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_akidjkegkj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akidjkegkj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492429, XrefRangeEnd = 1492568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_akjcidekhd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akjcidekhd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492568, XrefRangeEnd = 1492585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_akjiekjkkh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akjiekjkkh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492585, XrefRangeEnd = 1492612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cbbeifjkdj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cbbeifjkdj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492612, XrefRangeEnd = 1492623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cbffeddche(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cbffeddche_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492623, XrefRangeEnd = 1492652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cbggkebbfk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cbggkebbfk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492652, XrefRangeEnd = 1492854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cbhkgfiiif(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cbhkgfiiif_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492854, XrefRangeEnd = 1492906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cbjidfdhfg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cbjidfdhfg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492906, XrefRangeEnd = 1492947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cbkcbhjiek(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cbkcbhjiek_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492947, XrefRangeEnd = 1492975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cbkfhfcjb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cbkfhfcjb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492975, XrefRangeEnd = 1492992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ccbfibgeci(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ccbfibgeci_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1492992, XrefRangeEnd = 1493029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cccffebffc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cccffebffc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1493029, XrefRangeEnd = 1493037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cccggcfdkg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cccggcfdkg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1493037, XrefRangeEnd = 1493170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ccekgicgfh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ccekgicgfh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1493170, XrefRangeEnd = 1493222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ccfhfbhikj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ccfhfbhikj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1493222, XrefRangeEnd = 1493262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ccgjgbjcgi(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ccgjgbjcgi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1493262, XrefRangeEnd = 1493349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cchfdhghjd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cchfdhghjd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1493349, XrefRangeEnd = 1493463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cddckigibk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cddckigibk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1493463, XrefRangeEnd = 1493605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cdedfgfkdj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdedfgfkdj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1493605, XrefRangeEnd = 1493702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cdfdcchhe(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdfdcchhe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1493702, XrefRangeEnd = 1493765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cdfibdbkfb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdfibdbkfb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1493765, XrefRangeEnd = 1493855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cdfjfbikid(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdfjfbikid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1493855, XrefRangeEnd = 1493992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cdgbkkidfd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdgbkkidfd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1493992, XrefRangeEnd = 1494021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cdgibkchih(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdgibkchih_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1494021, XrefRangeEnd = 1494056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cdidfjjidb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdidfjjidb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1494056, XrefRangeEnd = 1494089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cdjkcdjcgc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdjkcdjcgc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1494089, XrefRangeEnd = 1494113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cebdekghcc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cebdekghcc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1494113, XrefRangeEnd = 1494267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ceceehkkdb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ceceehkkdb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1494267, XrefRangeEnd = 1494282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cechbcjbje(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cechbcjbje_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1494282, XrefRangeEnd = 1494299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cechggbfcg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cechggbfcg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1494299, XrefRangeEnd = 1494504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cechibbibc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cechibbibc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1494504, XrefRangeEnd = 1494723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cedekbhedh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cedekbhedh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1494723, XrefRangeEnd = 1494752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ceecjebgfd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ceecjebgfd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1494752, XrefRangeEnd = 1494796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ceffhbdbf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ceffhbdbf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1494796, XrefRangeEnd = 1494963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cegbicbcfg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cegbicbcfg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1494963, XrefRangeEnd = 1495029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cegkcgkkgb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cegkcgkkgb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495029, XrefRangeEnd = 1495130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ceiggdddik(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ceiggdddik_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495130, XrefRangeEnd = 1495141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cejhdeejck(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cejhdeejck_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495141, XrefRangeEnd = 1495283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cekhfceefg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cekhfceefg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495283, XrefRangeEnd = 1495395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cfbedkikg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfbedkikg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495395, XrefRangeEnd = 1495479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cfbjdedjcj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfbjdedjcj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495479, XrefRangeEnd = 1495630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cfbjghgjgf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfbjghgjgf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495630, XrefRangeEnd = 1495661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cfcfjiceg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfcfjiceg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495661, XrefRangeEnd = 1495727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cfcjbdhdik(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfcjbdhdik_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495727, XrefRangeEnd = 1495785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cfcjgefdjg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfcjgefdjg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495785, XrefRangeEnd = 1495814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cfedcgehh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfedcgehh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495814, XrefRangeEnd = 1495832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cfffedbhfg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfffedbhfg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495832, XrefRangeEnd = 1495864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cfiggjfcfh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfiggjfcfh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495864, XrefRangeEnd = 1495957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cfjbbdjcdi(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfjbbdjcdi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495957, XrefRangeEnd = 1495988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cfkdeghg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfkdeghg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495988, XrefRangeEnd = 1496011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cgbbhfbgbj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cgbbhfbgbj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496011, XrefRangeEnd = 1496042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cgbeibighh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cgbeibighh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496042, XrefRangeEnd = 1496072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cgdieefdkk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cgdieefdkk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496072, XrefRangeEnd = 1496095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cghhdebggi(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cghhdebggi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496095, XrefRangeEnd = 1496240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cgighkjefc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cgighkjefc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496240, XrefRangeEnd = 1496281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cgjchkijib(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cgjchkijib_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496281, XrefRangeEnd = 1496292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_chdckkkgkg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chdckkkgkg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496292, XrefRangeEnd = 1496378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_chedkdbce(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chedkdbce_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496378, XrefRangeEnd = 1496472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_chhcdcgigb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chhcdcgigb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496472, XrefRangeEnd = 1496552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_chibdbkfde(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chibdbkfde_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496552, XrefRangeEnd = 1496572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_chibgkeeji(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chibgkeeji_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496572, XrefRangeEnd = 1496708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_chiceijbgj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chiceijbgj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496708, XrefRangeEnd = 1496719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_chiffhjbee(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chiffhjbee_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496719, XrefRangeEnd = 1496743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_chiiihhffh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chiiihhffh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496743, XrefRangeEnd = 1496830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cichefikeb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cichefikeb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496830, XrefRangeEnd = 1496841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cicjgdikig(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cicjgdikig_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496841, XrefRangeEnd = 1496914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cifbcfjkdj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cifbcfjkdj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1496914, XrefRangeEnd = 1497014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cigfkckdgc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cigfkckdgc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497014, XrefRangeEnd = 1497040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cijeifhgec(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cijeifhgec_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497040, XrefRangeEnd = 1497201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cijijgbkgk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cijijgbkgk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497201, XrefRangeEnd = 1497212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cjbcjhhgke(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjbcjhhgke_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497212, XrefRangeEnd = 1497254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cjbjeehdbk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjbjeehdbk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497254, XrefRangeEnd = 1497313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cjdkihjijd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjdkihjijd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497313, XrefRangeEnd = 1497333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cjfdcbgfgj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjfdcbgfgj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497333, XrefRangeEnd = 1497357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cjgbfhfgef(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjgbfhfgef_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497357, XrefRangeEnd = 1497385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cjhkjfhhf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjhkjfhhf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497385, XrefRangeEnd = 1497467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cjicjgdfff(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjicjgdfff_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497467, XrefRangeEnd = 1497494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cjjdbgbddi(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjjdbgbddi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497494, XrefRangeEnd = 1497592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cjjdkdfkkh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjjdkdfkkh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497592, XrefRangeEnd = 1497620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_cjjjckihek(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjjjckihek_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497620, XrefRangeEnd = 1497762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ckbiikefid(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ckbiikefid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497762, XrefRangeEnd = 1497794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ckeiejdgib(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ckeiejdgib_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497794, XrefRangeEnd = 1497825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ckkddehif(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ckkddehif_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497825, XrefRangeEnd = 1497871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dbbbcebccf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dbbbcebccf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497871, XrefRangeEnd = 1497905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dbedicfecc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dbedicfecc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497905, XrefRangeEnd = 1497939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dbfehhjdb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dbfehhjdb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497939, XrefRangeEnd = 1497965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dbibcdhcc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dbibcdhcc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497965, XrefRangeEnd = 1497991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dbjjcgeeki(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dbjjcgeeki_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1497991, XrefRangeEnd = 1498040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dcbffdidkk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dcbffdidkk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498040, XrefRangeEnd = 1498086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dcbkfgcjid(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dcbkfgcjid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498086, XrefRangeEnd = 1498112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dcdjbbkec(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dcdjbbkec_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498112, XrefRangeEnd = 1498129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dcebfkhcgc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dcebfkhcgc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498129, XrefRangeEnd = 1498143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dcecciefge(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dcecciefge_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498143, XrefRangeEnd = 1498166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dcehkgkifb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dcehkgkifb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498166, XrefRangeEnd = 1498184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dcfehdgdkj(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dcfehdgdkj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498184, XrefRangeEnd = 1498274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ddffjifbf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ddffjifbf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498274, XrefRangeEnd = 1498300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ddikijcge(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ddikijcge_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498300, XrefRangeEnd = 1498392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_debdghice(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_debdghice_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498392, XrefRangeEnd = 1498421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dfcjdjkjk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dfcjdjkjk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498421, XrefRangeEnd = 1498560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dfjibkhbh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dfjibkhbh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498560, XrefRangeEnd = 1498608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_dihkeehk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dihkeehk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498608, XrefRangeEnd = 1498645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_djigibich(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_djigibich_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498645, XrefRangeEnd = 1498711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ebgkehdgb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ebgkehdgb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498711, XrefRangeEnd = 1498828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ecgibfdjb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ecgibfdjb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498828, XrefRangeEnd = 1498854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_edfkjgfch(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_edfkjgfch_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498854, XrefRangeEnd = 1498885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ehkcekjii(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ehkcekjii_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1498885, XrefRangeEnd = 1499024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_eidhfehik(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_eidhfehik_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499024, XrefRangeEnd = 1499056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_eiehjkdd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_eiehjkdd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499056, XrefRangeEnd = 1499198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ejjgbkdff(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ejjgbkdff_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499198, XrefRangeEnd = 1499218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ejkdcifhg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ejkdcifhg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499218, XrefRangeEnd = 1499311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_fbejgkdib(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fbejgkdib_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499311, XrefRangeEnd = 1499331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_fdjggbfcb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fdjggbfcb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499331, XrefRangeEnd = 1499357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_fdkkidgb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fdkkidgb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499357, XrefRangeEnd = 1499399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_fekcijijf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fekcijijf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499399, XrefRangeEnd = 1499422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_fgcbdbbid(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fgcbdbbid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499422, XrefRangeEnd = 1499454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_fgfckhdf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fgfckhdf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499454, XrefRangeEnd = 1499480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_fhcdfebdc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fhcdfebdc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499480, XrefRangeEnd = 1499539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_fhjkfjice(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fhjkfjice_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499539, XrefRangeEnd = 1499559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_fihfdkijh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fihfdkijh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499559, XrefRangeEnd = 1499577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_fjkikekhi(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fjkikekhi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499577, XrefRangeEnd = 1499600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_fkbkbchgb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fkbkbchgb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499600, XrefRangeEnd = 1499641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_fkedkejgf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fkedkejgf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499641, XrefRangeEnd = 1499709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_fkfbciibe(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fkfbciibe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499709, XrefRangeEnd = 1499730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_gbchjfieb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_gbchjfieb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499730, XrefRangeEnd = 1499878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_gbibihicb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_gbibihicb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1499878, XrefRangeEnd = 1500017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_geijfbdhc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_geijfbdhc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500017, XrefRangeEnd = 1500049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_gfgdjegbe(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_gfgdjegbe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500049, XrefRangeEnd = 1500126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_gihjfdefi(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_gihjfdefi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500126, XrefRangeEnd = 1500144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_gjgidfgeh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_gjgidfgeh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500144, XrefRangeEnd = 1500173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_hbeefgbjc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hbeefgbjc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500173, XrefRangeEnd = 1500288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_hcehhjdfk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hcehhjdfk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500288, XrefRangeEnd = 1500385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_hekdkcdeh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hekdkcdeh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500385, XrefRangeEnd = 1500396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_hfjfeiijk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hfjfeiijk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500396, XrefRangeEnd = 1500535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_hhbehfckd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hhbehfckd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500535, XrefRangeEnd = 1500576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_hhkbgdice(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hhkbgdice_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500576, XrefRangeEnd = 1500620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_hikdcfgkb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hikdcfgkb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500620, XrefRangeEnd = 1500635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_hkdbgkgik(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hkdbgkgik_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500635, XrefRangeEnd = 1500677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ibbddjcfb(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ibbddjcfb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500677, XrefRangeEnd = 1500711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ichfccfhh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ichfccfhh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500711, XrefRangeEnd = 1500735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_idchgghie(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_idchgghie_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500735, XrefRangeEnd = 1500764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_iddeebfkg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_iddeebfkg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500764, XrefRangeEnd = 1500775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_iddhiekfi(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_iddhiekfi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500775, XrefRangeEnd = 1500788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_idjfhgckc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_idjfhgckc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500788, XrefRangeEnd = 1500860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ihbgcbhic(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ihbgcbhic_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500860, XrefRangeEnd = 1500880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_iicekghif(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_iicekghif_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500880, XrefRangeEnd = 1500919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_iifbheddf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_iifbheddf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500919, XrefRangeEnd = 1500978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_ikejdbedk(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ikejdbedk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1500978, XrefRangeEnd = 1501012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_jcdhbjde(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_jcdhbjde_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501012, XrefRangeEnd = 1501046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_jceehdeeh(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_jceehdeeh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501046, XrefRangeEnd = 1501075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_jchhdjhkg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_jchhdjhkg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501075, XrefRangeEnd = 1501101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_jgcekgbii(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_jgcekgbii_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501101, XrefRangeEnd = 1501118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_jigekbbhd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_jigekbbhd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501118, XrefRangeEnd = 1501129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_jjjcegjeg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_jjjcegjeg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501129, XrefRangeEnd = 1501184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_jkekeckbf(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_jkekeckbf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501184, XrefRangeEnd = 1501249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_kbcfjkedc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kbcfjkedc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501249, XrefRangeEnd = 1501260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_kdbikhddc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kdbikhddc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501260, XrefRangeEnd = 1501338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_kddgijibc(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kddgijibc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501338, XrefRangeEnd = 1501367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_kdhdheib(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kdhdheib_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501367, XrefRangeEnd = 1501399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_kfbbiddfg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kfbbiddfg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501399, XrefRangeEnd = 1501425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_kfkchgjdd(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kfkchgjdd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501425, XrefRangeEnd = 1501439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_kiighbfgg(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kiighbfgg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501439, XrefRangeEnd = 1501457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshot_kijdhbiid(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kijdhbiid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CopySnapshotsToGameplay()
      {
        Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem>.NativeClassPtr, nameof (CopySnapshotsToGameplay));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeFieldInfoPtr_CurrentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, nameof (CurrentFrame));
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, nameof (EntityManager));
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeFieldInfoPtr_SynchronizedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, nameof (SynchronizedEntities));
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeFieldInfoPtr_NetworkedIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, nameof (NetworkedIdToEntityMap));
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeFieldInfoPtr_ReceivedPrefabReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, nameof (ReceivedPrefabReferences));
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663761);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_RunJobForEntity_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663762);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbbdiefgbd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663763);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbbgiidegf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663764);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbdgdebikk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663765);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbfcjichfb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663766);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbhckcfdfd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663767);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbhkjccgdi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663768);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbicfeedbb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663769);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acbiddcjjid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663770);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acccfjkdigh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663771);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acccgefcedb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663772);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_accdbefiheb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663773);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_accdjiedgfe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663774);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_accgciikfbf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663775);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_accgiggcif_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663776);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acchhgcjcbh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663777);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acchibekekj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663778);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acciegkehkf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663779);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdccjhicfg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663780);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdehhkijdj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663781);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdfgkkfchc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663782);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdficciidc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663783);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdibbekbkk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663784);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdidhjbjgj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663785);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdjdjkckhd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663786);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdjighgcci_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663787);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdkgjbefjd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663788);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acdkkhcbdcg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663789);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acecggedbff_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663790);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aceegbjekgb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663791);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aceehcgeedj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663792);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acegbdcgkdf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663793);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aceihfcgifd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663794);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acekdgegehc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663795);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acekjgheehk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663796);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acfckgbfifj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663797);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acfebiceeh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663798);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acfhdekidie_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663799);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acfikjcfik_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663800);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acgbiiekebj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663801);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acgchdfhdbe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663802);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acgckficfjg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663803);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acgddgdckdd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663804);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acgefcgggfi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663805);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acgfefhihji_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663806);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acggehdijfg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663807);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acggfcbekbj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663808);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acggkbfbjck_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663809);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acghdchgjgf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663810);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achbffjechg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663811);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achbhefgeeh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663812);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achbhhddbh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663813);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achcbdhidik_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663814);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achdjgjdgkk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663815);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achfcefeheb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663816);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achgedhdigf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663817);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achgegcdkcj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663818);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achicekidek_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663819);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achiggdccdc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663820);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achjkedegdi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663821);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_achjkicgkif_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663822);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aciddedkjj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663823);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acidekciged_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663824);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acidjkkbgbk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663825);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acifkidfebh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663826);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acigkbdedfb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663827);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acihcehbbb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663828);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acihehkdfeh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663829);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acihkdjfdkb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663830);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aciibbeciec_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663831);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acikghjjgki_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663832);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acikhjeehkg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663833);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acjbgiffidc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663834);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acjdegcccg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663835);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acjigbfeikj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663836);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_acjkcgkfjff_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663837);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackbhgekeci_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663838);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackchfegcjc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663839);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackdkfeghk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663840);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackebkbdbjj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663841);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackffdikde_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663842);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackgdbibjbd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663843);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackifjdcjjd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663844);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackjbcfijee_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663845);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ackkecjdkk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663846);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbbickeikd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663847);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbfkibeiid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663848);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbfkjhfcjd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663849);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbgiccjej_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663850);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbhchjbgek_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663851);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbijghdjjj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663852);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbjcebiefe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663853);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbjdjfkiif_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663854);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbjkedbgjg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663855);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbjkhhkffi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663856);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adbkdbehhdh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663857);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adcbfjighfe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663858);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adcdbdebfjg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663859);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adcffdijihg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663860);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adejkghcfk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663861);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adekhbkfjb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663862);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adgbkkgkkc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663863);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adgcbgkcfb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663864);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adjbidcgdh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663865);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_adkecehjdk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663866);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aebfefikfc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663867);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aegjbedggh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663868);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aeibfebcie_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663869);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aejfcffkde_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663870);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afcdibbdhk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663871);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afdcikchcf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663872);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afdgichhbg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663873);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afdgigchdc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663874);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afejhccjki_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663875);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afgfgihgc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663876);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afghjhgcgk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663877);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afibjfgjj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663878);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afiidbjjg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663879);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_afkbfgfhef_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663880);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_agcdkcdjfe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663881);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_agfgchgici_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663882);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aggchckijc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663883);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_agghikgigk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663884);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aghhkgkfc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663885);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_agijkdicg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663886);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_agjkgikkig_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663887);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_agkckkkggd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663888);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ahbgechgbk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663889);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ahciehbbdc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663890);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ahiggbegei_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663891);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ahijjfgjce_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663892);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ahkcgijbei_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663893);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ahkijdhjcb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663894);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aicgdjfcgb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663895);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aidbefcifj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663896);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aidcegcehg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663897);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aiebecdijh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663898);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aieefjchbd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663899);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aiejbddfde_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663900);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aifejkfbkk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663901);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aifkcjfiic_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663902);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_aigchgfejj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663903);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ajcejdgdjc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663904);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ajchjhccfg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663905);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ajfedjbbig_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663906);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ajghhigdb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663907);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ajgkhchijb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663908);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ajkhbehfkf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663909);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akdddhikjj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663910);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akdhbfiiid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663911);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akfbbffjcg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663912);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akgbiefjbh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663913);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akhbjjbcei_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663914);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akhiekbd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663915);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akidjkegkj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663916);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akjcidekhd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663917);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_akjiekjkkh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663918);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cbbeifjkdj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663919);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cbffeddche_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663920);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cbggkebbfk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663921);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cbhkgfiiif_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663922);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cbjidfdhfg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663923);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cbkcbhjiek_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663924);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cbkfhfcjb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663925);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ccbfibgeci_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663926);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cccffebffc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663927);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cccggcfdkg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663928);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ccekgicgfh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663929);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ccfhfbhikj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663930);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ccgjgbjcgi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663931);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cchfdhghjd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663932);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cddckigibk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663933);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdedfgfkdj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663934);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdfdcchhe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663935);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdfibdbkfb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663936);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdfjfbikid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663937);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdgbkkidfd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663938);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdgibkchih_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663939);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdidfjjidb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663940);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cdjkcdjcgc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663941);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cebdekghcc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663942);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ceceehkkdb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663943);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cechbcjbje_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663944);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cechggbfcg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663945);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cechibbibc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663946);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cedekbhedh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663947);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ceecjebgfd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663948);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ceffhbdbf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663949);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cegbicbcfg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663950);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cegkcgkkgb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663951);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ceiggdddik_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663952);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cejhdeejck_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663953);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cekhfceefg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663954);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfbedkikg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663955);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfbjdedjcj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663956);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfbjghgjgf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663957);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfcfjiceg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663958);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfcjbdhdik_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663959);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfcjgefdjg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663960);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfedcgehh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663961);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfffedbhfg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663962);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfiggjfcfh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663963);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfjbbdjcdi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663964);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cfkdeghg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663965);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cgbbhfbgbj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663966);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cgbeibighh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663967);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cgdieefdkk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663968);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cghhdebggi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663969);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cgighkjefc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663970);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cgjchkijib_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663971);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chdckkkgkg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663972);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chedkdbce_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663973);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chhcdcgigb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663974);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chibdbkfde_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663975);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chibgkeeji_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663976);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chiceijbgj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663977);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chiffhjbee_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663978);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_chiiihhffh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663979);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cichefikeb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663980);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cicjgdikig_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663981);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cifbcfjkdj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663982);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cigfkckdgc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663983);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cijeifhgec_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663984);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cijijgbkgk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663985);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjbcjhhgke_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663986);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjbjeehdbk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663987);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjdkihjijd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663988);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjfdcbgfgj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663989);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjgbfhfgef_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663990);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjhkjfhhf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663991);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjicjgdfff_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663992);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjjdbgbddi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663993);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjjdkdfkkh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663994);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_cjjjckihek_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663995);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ckbiikefid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663996);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ckeiejdgib_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663997);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ckkddehif_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663998);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dbbbcebccf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100663999);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dbedicfecc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664000);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dbfehhjdb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664001);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dbibcdhcc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664002);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dbjjcgeeki_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664003);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dcbffdidkk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664004);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dcbkfgcjid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664005);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dcdjbbkec_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664006);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dcebfkhcgc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664007);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dcecciefge_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664008);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dcehkgkifb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664009);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dcfehdgdkj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664010);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ddffjifbf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664011);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ddikijcge_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664012);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_debdghice_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664013);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dfcjdjkjk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664014);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dfjibkhbh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664015);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_dihkeehk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664016);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_djigibich_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664017);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ebgkehdgb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664018);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ecgibfdjb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664019);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_edfkjgfch_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664020);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ehkcekjii_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664021);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_eidhfehik_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664022);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_eiehjkdd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664023);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ejjgbkdff_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664024);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ejkdcifhg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664025);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fbejgkdib_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664026);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fdjggbfcb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664027);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fdkkidgb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664028);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fekcijijf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664029);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fgcbdbbid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664030);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fgfckhdf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664031);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fhcdfebdc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664032);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fhjkfjice_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664033);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fihfdkijh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664034);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fjkikekhi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664035);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fkbkbchgb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664036);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fkedkejgf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664037);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_fkfbciibe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664038);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_gbchjfieb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664039);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_gbibihicb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664040);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_geijfbdhc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664041);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_gfgdjegbe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664042);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_gihjfdefi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664043);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_gjgidfgeh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664044);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hbeefgbjc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664045);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hcehhjdfk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664046);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hekdkcdeh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664047);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hfjfeiijk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664048);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hhbehfckd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664049);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hhkbgdice_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664050);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hikdcfgkb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664051);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_hkdbgkgik_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664052);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ibbddjcfb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664053);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ichfccfhh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664054);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_idchgghie_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664055);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_iddeebfkg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664056);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_iddhiekfi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664057);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_idjfhgckc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664058);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ihbgcbhic_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664059);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_iicekghif_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664060);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_iifbheddf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664061);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_ikejdbedk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664062);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_jcdhbjde_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664063);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_jceehdeeh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664064);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_jchhdjhkg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664065);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_jgcekgbii_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664066);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_jigekbbhd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664067);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_jjjcegjeg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664068);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_jkekeckbf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664069);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kbcfjkedc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664070);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kdbikhddc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664071);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kddgijibc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664072);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kdhdheib_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664073);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kfbbiddfg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664074);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kfkchgjdd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664075);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kiighbfgg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664076);
        CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay.NativeMethodInfoPtr_CopySnapshot_kijdhbiid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, 100664077);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopySnapshotsToEntitiesSystem.CopySnapshotsToGameplay>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
