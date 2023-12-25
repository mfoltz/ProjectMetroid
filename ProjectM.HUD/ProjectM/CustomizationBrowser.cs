// Decompiled with JetBrains decompiler
// Type: ProjectM.CustomizationBrowser
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class CustomizationBrowser : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_GenderIndex;
    private static readonly IntPtr NativeFieldInfoPtr_FaceIndex;
    private static readonly IntPtr NativeFieldInfoPtr_HairStyleIndex;
    private static readonly IntPtr NativeFieldInfoPtr_FeatureIndex;
    private static readonly IntPtr NativeFieldInfoPtr_AccessoryIndex;
    private static readonly IntPtr NativeFieldInfoPtr_SkinColorIndex;
    private static readonly IntPtr NativeFieldInfoPtr_HairColorIndex;
    private static readonly IntPtr NativeFieldInfoPtr_EyeColorIndex;
    private static readonly IntPtr NativeFieldInfoPtr_RotationNode;
    private static readonly IntPtr NativeFieldInfoPtr_CharacterSpawnNode;
    private static readonly IntPtr NativeFieldInfoPtr_GenderCollection;
    private static readonly IntPtr NativeFieldInfoPtr_EquipmentCollection;
    private static readonly IntPtr NativeFieldInfoPtr__ModelInstance;
    private static readonly IntPtr NativeFieldInfoPtr__ModelChanged;
    private static readonly IntPtr NativeFieldInfoPtr__PrevFaceKey;
    private static readonly IntPtr NativeFieldInfoPtr__PrevHairKey;
    private static readonly IntPtr NativeFieldInfoPtr__PrevFeatureKey;
    private static readonly IntPtr NativeFieldInfoPtr__PrevAccessoryKey;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetData_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetDefaultEquipment_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209752, XrefRangeEnd = 1209753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomizationBrowser.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1209758, RefRangeEnd = 1209759, XrefRangeStart = 1209753, XrefRangeEnd = 1209758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      int genderIndex,
      int skintoneColorIndex,
      int faceIndex,
      int eyeColorIndex,
      int hairIndex,
      int hairColorIndex,
      int featuresIndex,
      int accessoryIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[8];
      numPtr[0] = (IntPtr) &genderIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &skintoneColorIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &faceIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &eyeColorIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &hairIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &hairColorIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &featuresIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(7) * sizeof (IntPtr))) = (IntPtr) &accessoryIndex;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomizationBrowser.NativeMethodInfoPtr_SetData_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1209882, RefRangeEnd = 1209884, XrefRangeStart = 1209759, XrefRangeEnd = 1209882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomizationBrowser.NativeMethodInfoPtr_SetData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1209933, RefRangeEnd = 1209934, XrefRangeStart = 1209884, XrefRangeEnd = 1209933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetDefaultEquipment()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomizationBrowser.NativeMethodInfoPtr_SetDefaultEquipment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomizationBrowser()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomizationBrowser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CustomizationBrowser()
    {
      Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (CustomizationBrowser));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr);
      CustomizationBrowser.NativeFieldInfoPtr_GenderIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (GenderIndex));
      CustomizationBrowser.NativeFieldInfoPtr_FaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (FaceIndex));
      CustomizationBrowser.NativeFieldInfoPtr_HairStyleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (HairStyleIndex));
      CustomizationBrowser.NativeFieldInfoPtr_FeatureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (FeatureIndex));
      CustomizationBrowser.NativeFieldInfoPtr_AccessoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (AccessoryIndex));
      CustomizationBrowser.NativeFieldInfoPtr_SkinColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (SkinColorIndex));
      CustomizationBrowser.NativeFieldInfoPtr_HairColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (HairColorIndex));
      CustomizationBrowser.NativeFieldInfoPtr_EyeColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (EyeColorIndex));
      CustomizationBrowser.NativeFieldInfoPtr_RotationNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (RotationNode));
      CustomizationBrowser.NativeFieldInfoPtr_CharacterSpawnNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (CharacterSpawnNode));
      CustomizationBrowser.NativeFieldInfoPtr_GenderCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (GenderCollection));
      CustomizationBrowser.NativeFieldInfoPtr_EquipmentCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (EquipmentCollection));
      CustomizationBrowser.NativeFieldInfoPtr__ModelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (_ModelInstance));
      CustomizationBrowser.NativeFieldInfoPtr__ModelChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (_ModelChanged));
      CustomizationBrowser.NativeFieldInfoPtr__PrevFaceKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (_PrevFaceKey));
      CustomizationBrowser.NativeFieldInfoPtr__PrevHairKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (_PrevHairKey));
      CustomizationBrowser.NativeFieldInfoPtr__PrevFeatureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (_PrevFeatureKey));
      CustomizationBrowser.NativeFieldInfoPtr__PrevAccessoryKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, nameof (_PrevAccessoryKey));
      CustomizationBrowser.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, 100663643);
      CustomizationBrowser.NativeMethodInfoPtr_SetData_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, 100663644);
      CustomizationBrowser.NativeMethodInfoPtr_SetData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, 100663645);
      CustomizationBrowser.NativeMethodInfoPtr_SetDefaultEquipment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, 100663646);
      CustomizationBrowser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationBrowser>.NativeClassPtr, 100663647);
    }

    public CustomizationBrowser(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int GenderIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_GenderIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_GenderIndex)) = value;
      }
    }

    public unsafe int FaceIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_FaceIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_FaceIndex)) = value;
      }
    }

    public unsafe int HairStyleIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_HairStyleIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_HairStyleIndex)) = value;
      }
    }

    public unsafe int FeatureIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_FeatureIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_FeatureIndex)) = value;
      }
    }

    public unsafe int AccessoryIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_AccessoryIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_AccessoryIndex)) = value;
      }
    }

    public unsafe int SkinColorIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_SkinColorIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_SkinColorIndex)) = value;
      }
    }

    public unsafe int HairColorIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_HairColorIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_HairColorIndex)) = value;
      }
    }

    public unsafe int EyeColorIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_EyeColorIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_EyeColorIndex)) = value;
      }
    }

    public unsafe GameObject RotationNode
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_RotationNode));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_RotationNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject CharacterSpawnNode
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_CharacterSpawnNode));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_CharacterSpawnNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeaturesCollection GenderCollection
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_GenderCollection));
        return pointer == IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_GenderCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DefaultEquipmentCollectionAsset EquipmentCollection
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_EquipmentCollection));
        return pointer == IntPtr.Zero ? (DefaultEquipmentCollectionAsset) null : new DefaultEquipmentCollectionAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr_EquipmentCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HybridEquipmentUser _ModelInstance
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr__ModelInstance));
        return pointer == IntPtr.Zero ? (HybridEquipmentUser) null : new HybridEquipmentUser(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr__ModelInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _ModelChanged
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr__ModelChanged));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr__ModelChanged)) = value;
      }
    }

    public unsafe AttachmentKey _PrevFaceKey
    {
      get
      {
        return *(AttachmentKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr__PrevFaceKey));
      }
      [param: In] set
      {
        *(AttachmentKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr__PrevFaceKey)) = value;
      }
    }

    public unsafe AttachmentKey _PrevHairKey
    {
      get
      {
        return *(AttachmentKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr__PrevHairKey));
      }
      [param: In] set
      {
        *(AttachmentKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr__PrevHairKey)) = value;
      }
    }

    public unsafe AttachmentKey _PrevFeatureKey
    {
      get
      {
        return *(AttachmentKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr__PrevFeatureKey));
      }
      [param: In] set
      {
        *(AttachmentKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr__PrevFeatureKey)) = value;
      }
    }

    public unsafe AttachmentKey _PrevAccessoryKey
    {
      get
      {
        return *(AttachmentKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr__PrevAccessoryKey));
      }
      [param: In] set
      {
        *(AttachmentKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomizationBrowser.NativeFieldInfoPtr__PrevAccessoryKey)) = value;
      }
    }
  }
}
