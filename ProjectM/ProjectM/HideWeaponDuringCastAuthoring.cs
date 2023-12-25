// Decompiled with JetBrains decompiler
// Type: ProjectM.HideWeaponDuringCastAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class HideWeaponDuringCastAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Sequence;
    private static readonly IntPtr NativeFieldInfoPtr_Type;
    private static readonly IntPtr NativeFieldInfoPtr_CustomDuration;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996166, XrefRangeEnd = 996181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HideWeaponDuringCastAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996181, XrefRangeEnd = 996182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HideWeaponDuringCastAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideWeaponDuringCastAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HideWeaponDuringCastAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HideWeaponDuringCastAuthoring()
    {
      Il2CppClassPointerStore<HideWeaponDuringCastAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HideWeaponDuringCastAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideWeaponDuringCastAuthoring>.NativeClassPtr);
      HideWeaponDuringCastAuthoring.NativeFieldInfoPtr_Sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideWeaponDuringCastAuthoring>.NativeClassPtr, nameof (Sequence));
      HideWeaponDuringCastAuthoring.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideWeaponDuringCastAuthoring>.NativeClassPtr, nameof (Type));
      HideWeaponDuringCastAuthoring.NativeFieldInfoPtr_CustomDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideWeaponDuringCastAuthoring>.NativeClassPtr, nameof (CustomDuration));
      HideWeaponDuringCastAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideWeaponDuringCastAuthoring>.NativeClassPtr, 100676959);
      HideWeaponDuringCastAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideWeaponDuringCastAuthoring>.NativeClassPtr, 100676960);
    }

    public HideWeaponDuringCastAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SequenceEditorObject Sequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideWeaponDuringCastAuthoring.NativeFieldInfoPtr_Sequence));
        return pointer == IntPtr.Zero ? (SequenceEditorObject) null : new SequenceEditorObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideWeaponDuringCastAuthoring.NativeFieldInfoPtr_Sequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HideWeaponDuringCastType Type
    {
      get
      {
        return *(HideWeaponDuringCastType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideWeaponDuringCastAuthoring.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(HideWeaponDuringCastType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideWeaponDuringCastAuthoring.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe float CustomDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideWeaponDuringCastAuthoring.NativeFieldInfoPtr_CustomDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideWeaponDuringCastAuthoring.NativeFieldInfoPtr_CustomDuration)) = value;
      }
    }
  }
}
