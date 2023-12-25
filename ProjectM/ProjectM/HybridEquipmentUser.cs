// Decompiled with JetBrains decompiler
// Type: ProjectM.HybridEquipmentUser
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using MagicaCloth;
using ProjectM.Hybrid;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class HybridEquipmentUser : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RootBone;
    private static readonly System.IntPtr NativeFieldInfoPtr_FemaleVampire;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloakBottom;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FaceCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeatureCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_AccessoryCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairColorCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_SkinColorCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_EyeColorCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeadColliders;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeckColliders;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChestColliders;
    private static readonly System.IntPtr NativeFieldInfoPtr_GutColliders;
    private static readonly System.IntPtr NativeFieldInfoPtr_PelvisColliders;
    private static readonly System.IntPtr NativeFieldInfoPtr_LeftLegColliders;
    private static readonly System.IntPtr NativeFieldInfoPtr_RightLegColliders;
    private static readonly System.IntPtr NativeFieldInfoPtr_LeftArmColliders;
    private static readonly System.IntPtr NativeFieldInfoPtr_RightArmColliders;
    private static readonly System.IntPtr NativeFieldInfoPtr_MountColliders;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloakColliders;
    private static readonly System.IntPtr NativeFieldInfoPtr__BonesMappings;
    private static readonly System.IntPtr NativeFieldInfoPtr__HybridModelRendererComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr__HybridModelBonesComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr__HybridModelAnimationComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentAttached;
    private static readonly System.IntPtr NativeFieldInfoPtr__CustomizationColors;
    private static readonly System.IntPtr NativeFieldInfoPtr__ColliderComponents;
    private static readonly System.IntPtr NativeFieldInfoPtr__TransformComponents;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshCustomizationColors_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHairColor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSkinColor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetEyeColor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAttachment_Public_Void_AttachmentKey_HybridEquipmentComponent_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAttachment_Public_Void_AttachmentKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasAttachmentOfType_Public_Boolean_CustomizationCategoryEnum_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAttachmentsOfType_Public_Void_CustomizationCategoryEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAttachmentAtIndex_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindBone_Private_Static_Boolean_Il2CppReferenceArray_1_BoneMapping_String_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Boolean_Il2CppReferenceArray_1_Il2CppReferenceArray_1_ColliderComponent_byref___c__DisplayClass36_0_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044944, XrefRangeEnd = 1045008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentUser.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045008, XrefRangeEnd = 1045026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshCustomizationColors()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentUser.NativeMethodInfoPtr_RefreshCustomizationColors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1045034, RefRangeEnd = 1045036, XrefRangeStart = 1045026, XrefRangeEnd = 1045034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetHairColor(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentUser.NativeMethodInfoPtr_SetHairColor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1045044, RefRangeEnd = 1045046, XrefRangeStart = 1045036, XrefRangeEnd = 1045044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetSkinColor(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentUser.NativeMethodInfoPtr_SetSkinColor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1045054, RefRangeEnd = 1045056, XrefRangeStart = 1045046, XrefRangeEnd = 1045054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetEyeColor(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentUser.NativeMethodInfoPtr_SetEyeColor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 1045290, RefRangeEnd = 1045303, XrefRangeStart = 1045056, XrefRangeEnd = 1045290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddAttachment(
      AttachmentKey attachmentKey,
      HybridEquipmentComponent prefab,
      bool isLocalPlayer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &attachmentKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isLocalPlayer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentUser.NativeMethodInfoPtr_AddAttachment_Public_Void_AttachmentKey_HybridEquipmentComponent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1045341, RefRangeEnd = 1045342, XrefRangeStart = 1045303, XrefRangeEnd = 1045341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveAttachment(AttachmentKey attachmentKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &attachmentKey;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentUser.NativeMethodInfoPtr_RemoveAttachment_Public_Void_AttachmentKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1045344, RefRangeEnd = 1045345, XrefRangeStart = 1045342, XrefRangeEnd = 1045344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasAttachmentOfType(
      CustomizationCategoryEnum customizationCategory,
      int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &customizationCategory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridEquipmentUser.NativeMethodInfoPtr_HasAttachmentOfType_Public_Boolean_CustomizationCategoryEnum_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1045347, RefRangeEnd = 1045355, XrefRangeStart = 1045345, XrefRangeEnd = 1045347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveAttachmentsOfType(CustomizationCategoryEnum customizationCategory)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &customizationCategory;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentUser.NativeMethodInfoPtr_RemoveAttachmentsOfType_Public_Void_CustomizationCategoryEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1045390, RefRangeEnd = 1045391, XrefRangeStart = 1045355, XrefRangeEnd = 1045390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveAttachmentAtIndex(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentUser.NativeMethodInfoPtr_RemoveAttachmentAtIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045391, XrefRangeEnd = 1045393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindBone(
      Il2CppReferenceArray<HybridEquipmentUser.BoneMapping> skeletonBones,
      string boneName,
      out int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) skeletonBones);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(boneName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridEquipmentUser.NativeMethodInfoPtr_TryFindBone_Private_Static_Boolean_Il2CppReferenceArray_1_BoneMapping_String_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045393, XrefRangeEnd = 1045403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddComponent(
      World world,
      PrefabLookupMap prefabLookupMap,
      Entity hybridEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hybridEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentUser.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045403, XrefRangeEnd = 1045438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridEquipmentUser()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentUser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1045441, RefRangeEnd = 1045447, XrefRangeStart = 1045438, XrefRangeEnd = 1045441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Internal_Static_Void_Boolean_Il2CppReferenceArray_1_Il2CppReferenceArray_1_ColliderComponent_byref___c__DisplayClass36_0_0(
      bool con,
      Il2CppReferenceArray<Il2CppReferenceArray<ColliderComponent>> colliders,
      ref HybridEquipmentUser.__c__DisplayClass36_0 _param2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &con;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) colliders);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param2);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentUser.NativeMethodInfoPtr_Method_Internal_Static_Void_Boolean_Il2CppReferenceArray_1_Il2CppReferenceArray_1_ColliderComponent_byref___c__DisplayClass36_0_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridEquipmentUser()
    {
      Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HybridEquipmentUser));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr);
      HybridEquipmentUser.NativeFieldInfoPtr_RootBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (RootBone));
      HybridEquipmentUser.NativeFieldInfoPtr_FemaleVampire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (FemaleVampire));
      HybridEquipmentUser.NativeFieldInfoPtr_CloakBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (CloakBottom));
      HybridEquipmentUser.NativeFieldInfoPtr_HairCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (HairCollection));
      HybridEquipmentUser.NativeFieldInfoPtr_FaceCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (FaceCollection));
      HybridEquipmentUser.NativeFieldInfoPtr_FeatureCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (FeatureCollection));
      HybridEquipmentUser.NativeFieldInfoPtr_AccessoryCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (AccessoryCollection));
      HybridEquipmentUser.NativeFieldInfoPtr_HairColorCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (HairColorCollection));
      HybridEquipmentUser.NativeFieldInfoPtr_SkinColorCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (SkinColorCollection));
      HybridEquipmentUser.NativeFieldInfoPtr_EyeColorCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (EyeColorCollection));
      HybridEquipmentUser.NativeFieldInfoPtr_HeadColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (HeadColliders));
      HybridEquipmentUser.NativeFieldInfoPtr_NeckColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (NeckColliders));
      HybridEquipmentUser.NativeFieldInfoPtr_ChestColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (ChestColliders));
      HybridEquipmentUser.NativeFieldInfoPtr_GutColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (GutColliders));
      HybridEquipmentUser.NativeFieldInfoPtr_PelvisColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (PelvisColliders));
      HybridEquipmentUser.NativeFieldInfoPtr_LeftLegColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (LeftLegColliders));
      HybridEquipmentUser.NativeFieldInfoPtr_RightLegColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (RightLegColliders));
      HybridEquipmentUser.NativeFieldInfoPtr_LeftArmColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (LeftArmColliders));
      HybridEquipmentUser.NativeFieldInfoPtr_RightArmColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (RightArmColliders));
      HybridEquipmentUser.NativeFieldInfoPtr_MountColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (MountColliders));
      HybridEquipmentUser.NativeFieldInfoPtr_CloakColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (CloakColliders));
      HybridEquipmentUser.NativeFieldInfoPtr__BonesMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (_BonesMappings));
      HybridEquipmentUser.NativeFieldInfoPtr__HybridModelRendererComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (_HybridModelRendererComponent));
      HybridEquipmentUser.NativeFieldInfoPtr__HybridModelBonesComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (_HybridModelBonesComponent));
      HybridEquipmentUser.NativeFieldInfoPtr__HybridModelAnimationComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (_HybridModelAnimationComponent));
      HybridEquipmentUser.NativeFieldInfoPtr__CurrentAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (_CurrentAttached));
      HybridEquipmentUser.NativeFieldInfoPtr__CustomizationColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (_CustomizationColors));
      HybridEquipmentUser.NativeFieldInfoPtr__ColliderComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (_ColliderComponents));
      HybridEquipmentUser.NativeFieldInfoPtr__TransformComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (_TransformComponents));
      HybridEquipmentUser.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, 100681885);
      HybridEquipmentUser.NativeMethodInfoPtr_RefreshCustomizationColors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, 100681886);
      HybridEquipmentUser.NativeMethodInfoPtr_SetHairColor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, 100681887);
      HybridEquipmentUser.NativeMethodInfoPtr_SetSkinColor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, 100681888);
      HybridEquipmentUser.NativeMethodInfoPtr_SetEyeColor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, 100681889);
      HybridEquipmentUser.NativeMethodInfoPtr_AddAttachment_Public_Void_AttachmentKey_HybridEquipmentComponent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, 100681890);
      HybridEquipmentUser.NativeMethodInfoPtr_RemoveAttachment_Public_Void_AttachmentKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, 100681891);
      HybridEquipmentUser.NativeMethodInfoPtr_HasAttachmentOfType_Public_Boolean_CustomizationCategoryEnum_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, 100681892);
      HybridEquipmentUser.NativeMethodInfoPtr_RemoveAttachmentsOfType_Public_Void_CustomizationCategoryEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, 100681893);
      HybridEquipmentUser.NativeMethodInfoPtr_RemoveAttachmentAtIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, 100681894);
      HybridEquipmentUser.NativeMethodInfoPtr_TryFindBone_Private_Static_Boolean_Il2CppReferenceArray_1_BoneMapping_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, 100681895);
      HybridEquipmentUser.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, 100681896);
      HybridEquipmentUser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, 100681897);
      HybridEquipmentUser.NativeMethodInfoPtr_Method_Internal_Static_Void_Boolean_Il2CppReferenceArray_1_Il2CppReferenceArray_1_ColliderComponent_byref___c__DisplayClass36_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, 100681899);
    }

    public HybridEquipmentUser(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Transform RootBone
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_RootBone));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_RootBone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool FemaleVampire
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_FemaleVampire));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_FemaleVampire)) = value;
      }
    }

    public unsafe SkinnedMeshRenderer CloakBottom
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_CloakBottom));
        return pointer == System.IntPtr.Zero ? (SkinnedMeshRenderer) null : new SkinnedMeshRenderer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_CloakBottom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeaturesCollection HairCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_HairCollection));
        return pointer == System.IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_HairCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeaturesCollection FaceCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_FaceCollection));
        return pointer == System.IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_FaceCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeaturesCollection FeatureCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_FeatureCollection));
        return pointer == System.IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_FeatureCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeaturesCollection AccessoryCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_AccessoryCollection));
        return pointer == System.IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_AccessoryCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ColorCollection HairColorCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_HairColorCollection));
        return pointer == System.IntPtr.Zero ? (ColorCollection) null : new ColorCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_HairColorCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ColorCollection SkinColorCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_SkinColorCollection));
        return pointer == System.IntPtr.Zero ? (ColorCollection) null : new ColorCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_SkinColorCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ColorCollection EyeColorCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_EyeColorCollection));
        return pointer == System.IntPtr.Zero ? (ColorCollection) null : new ColorCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_EyeColorCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ColliderComponent> HeadColliders
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_HeadColliders));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ColliderComponent>) null : new Il2CppReferenceArray<ColliderComponent>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_HeadColliders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ColliderComponent> NeckColliders
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_NeckColliders));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ColliderComponent>) null : new Il2CppReferenceArray<ColliderComponent>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_NeckColliders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ColliderComponent> ChestColliders
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_ChestColliders));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ColliderComponent>) null : new Il2CppReferenceArray<ColliderComponent>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_ChestColliders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ColliderComponent> GutColliders
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_GutColliders));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ColliderComponent>) null : new Il2CppReferenceArray<ColliderComponent>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_GutColliders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ColliderComponent> PelvisColliders
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_PelvisColliders));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ColliderComponent>) null : new Il2CppReferenceArray<ColliderComponent>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_PelvisColliders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ColliderComponent> LeftLegColliders
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_LeftLegColliders));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ColliderComponent>) null : new Il2CppReferenceArray<ColliderComponent>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_LeftLegColliders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ColliderComponent> RightLegColliders
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_RightLegColliders));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ColliderComponent>) null : new Il2CppReferenceArray<ColliderComponent>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_RightLegColliders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ColliderComponent> LeftArmColliders
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_LeftArmColliders));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ColliderComponent>) null : new Il2CppReferenceArray<ColliderComponent>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_LeftArmColliders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ColliderComponent> RightArmColliders
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_RightArmColliders));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ColliderComponent>) null : new Il2CppReferenceArray<ColliderComponent>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_RightArmColliders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ColliderComponent> MountColliders
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_MountColliders));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ColliderComponent>) null : new Il2CppReferenceArray<ColliderComponent>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_MountColliders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ColliderComponent> CloakColliders
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_CloakColliders));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ColliderComponent>) null : new Il2CppReferenceArray<ColliderComponent>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr_CloakColliders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<HybridEquipmentUser.BoneMapping> _BonesMappings
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr__BonesMappings));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<HybridEquipmentUser.BoneMapping>) null : new Il2CppReferenceArray<HybridEquipmentUser.BoneMapping>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr__BonesMappings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HybridModelRendererComponent _HybridModelRendererComponent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr__HybridModelRendererComponent));
        return pointer == System.IntPtr.Zero ? (HybridModelRendererComponent) null : new HybridModelRendererComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr__HybridModelRendererComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HybridModelBonesComponent _HybridModelBonesComponent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr__HybridModelBonesComponent));
        return pointer == System.IntPtr.Zero ? (HybridModelBonesComponent) null : new HybridModelBonesComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr__HybridModelBonesComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HybridModelAnimationComponent _HybridModelAnimationComponent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr__HybridModelAnimationComponent));
        return pointer == System.IntPtr.Zero ? (HybridModelAnimationComponent) null : new HybridModelAnimationComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr__HybridModelAnimationComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StructList<HybridEquipmentUser.AttachedInstances> _CurrentAttached
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr__CurrentAttached));
        return pointer == System.IntPtr.Zero ? (StructList<HybridEquipmentUser.AttachedInstances>) null : new StructList<HybridEquipmentUser.AttachedInstances>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr__CurrentAttached), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomizationColors _CustomizationColors
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr__CustomizationColors));
        return pointer == System.IntPtr.Zero ? (CustomizationColors) null : new CustomizationColors(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.NativeFieldInfoPtr__CustomizationColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe List<ColliderComponent> _ColliderComponents
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(HybridEquipmentUser.NativeFieldInfoPtr__ColliderComponents, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<ColliderComponent>) null : new List<ColliderComponent>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridEquipmentUser.NativeFieldInfoPtr__ColliderComponents, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe List<Transform> _TransformComponents
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(HybridEquipmentUser.NativeFieldInfoPtr__TransformComponents, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<Transform>) null : new List<Transform>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridEquipmentUser.NativeFieldInfoPtr__TransformComponents, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class BoneMapping : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Transform;

      static BoneMapping()
      {
        Il2CppClassPointerStore<HybridEquipmentUser.BoneMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (BoneMapping));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridEquipmentUser.BoneMapping>.NativeClassPtr);
        HybridEquipmentUser.BoneMapping.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser.BoneMapping>.NativeClassPtr, nameof (Name));
        HybridEquipmentUser.BoneMapping.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser.BoneMapping>.NativeClassPtr, nameof (Transform));
      }

      public BoneMapping(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public BoneMapping()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HybridEquipmentUser.BoneMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridEquipmentUser.BoneMapping>.NativeClassPtr, data));
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.BoneMapping.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.BoneMapping.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe Transform Transform
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.BoneMapping.NativeFieldInfoPtr_Transform));
          return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.BoneMapping.NativeFieldInfoPtr_Transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class AttachedInstances : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AttachmentKey;
      private static readonly System.IntPtr NativeFieldInfoPtr_Instance;

      static AttachedInstances()
      {
        Il2CppClassPointerStore<HybridEquipmentUser.AttachedInstances>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, nameof (AttachedInstances));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridEquipmentUser.AttachedInstances>.NativeClassPtr);
        HybridEquipmentUser.AttachedInstances.NativeFieldInfoPtr_AttachmentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser.AttachedInstances>.NativeClassPtr, nameof (AttachmentKey));
        HybridEquipmentUser.AttachedInstances.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser.AttachedInstances>.NativeClassPtr, nameof (Instance));
      }

      public AttachedInstances(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public AttachedInstances()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HybridEquipmentUser.AttachedInstances>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridEquipmentUser.AttachedInstances>.NativeClassPtr, data));
      }

      public unsafe AttachmentKey AttachmentKey
      {
        get
        {
          return *(AttachmentKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.AttachedInstances.NativeFieldInfoPtr_AttachmentKey));
        }
        [param: In] set
        {
          *(AttachmentKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.AttachedInstances.NativeFieldInfoPtr_AttachmentKey)) = value;
        }
      }

      public unsafe HybridEquipmentComponent Instance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.AttachedInstances.NativeFieldInfoPtr_Instance));
          return pointer == System.IntPtr.Zero ? (HybridEquipmentComponent) null : new HybridEquipmentComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.AttachedInstances.NativeFieldInfoPtr_Instance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.HybridEquipmentUser/<>c__DisplayClass36_0")]
    public sealed class __c__DisplayClass36_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_item;

      static __c__DisplayClass36_0()
      {
        Il2CppClassPointerStore<HybridEquipmentUser.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridEquipmentUser>.NativeClassPtr, "<>c__DisplayClass36_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridEquipmentUser.__c__DisplayClass36_0>.NativeClassPtr);
        HybridEquipmentUser.__c__DisplayClass36_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentUser.__c__DisplayClass36_0>.NativeClassPtr, nameof (item));
      }

      public __c__DisplayClass36_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass36_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HybridEquipmentUser.__c__DisplayClass36_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridEquipmentUser.__c__DisplayClass36_0>.NativeClassPtr, data));
      }

      public unsafe HybridEquipmentSkinnedMesh item
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.__c__DisplayClass36_0.NativeFieldInfoPtr_item));
          return pointer == System.IntPtr.Zero ? (HybridEquipmentSkinnedMesh) null : new HybridEquipmentSkinnedMesh(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentUser.__c__DisplayClass36_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
