// Decompiled with JetBrains decompiler
// Type: ProjectM.JumpFromCliffsComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class JumpFromCliffsComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_JumpDownTravelSpell;
    private static readonly IntPtr NativeFieldInfoPtr_JumpUpBuff;
    private static readonly IntPtr NativeFieldInfoPtr_CheckAgainstMapFlags;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010988, XrefRangeEnd = 1011001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(JumpFromCliffsComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011001, XrefRangeEnd = 1011002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JumpFromCliffsComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JumpFromCliffsComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JumpFromCliffsComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static JumpFromCliffsComponent()
    {
      Il2CppClassPointerStore<JumpFromCliffsComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (JumpFromCliffsComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JumpFromCliffsComponent>.NativeClassPtr);
      JumpFromCliffsComponent.NativeFieldInfoPtr_JumpDownTravelSpell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsComponent>.NativeClassPtr, nameof (JumpDownTravelSpell));
      JumpFromCliffsComponent.NativeFieldInfoPtr_JumpUpBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsComponent>.NativeClassPtr, nameof (JumpUpBuff));
      JumpFromCliffsComponent.NativeFieldInfoPtr_CheckAgainstMapFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsComponent>.NativeClassPtr, nameof (CheckAgainstMapFlags));
      JumpFromCliffsComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumpFromCliffsComponent>.NativeClassPtr, 100678647);
      JumpFromCliffsComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumpFromCliffsComponent>.NativeClassPtr, 100678648);
    }

    public JumpFromCliffsComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent JumpDownTravelSpell
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsComponent.NativeFieldInfoPtr_JumpDownTravelSpell));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsComponent.NativeFieldInfoPtr_JumpDownTravelSpell), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent JumpUpBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsComponent.NativeFieldInfoPtr_JumpUpBuff));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsComponent.NativeFieldInfoPtr_JumpUpBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapCollisionFlags CheckAgainstMapFlags
    {
      get
      {
        return *(MapCollisionFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsComponent.NativeFieldInfoPtr_CheckAgainstMapFlags));
      }
      [param: In] set
      {
        *(MapCollisionFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsComponent.NativeFieldInfoPtr_CheckAgainstMapFlags)) = value;
      }
    }
  }
}
