// Decompiled with JetBrains decompiler
// Type: ProjectM.SetDynamicCollisionHardnessBuffAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class SetDynamicCollisionHardnessBuffAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Hardness;
    private static readonly IntPtr NativeFieldInfoPtr_Targets;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034501, XrefRangeEnd = 1034504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(SetDynamicCollisionHardnessBuffAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetDynamicCollisionHardnessBuffAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetDynamicCollisionHardnessBuffAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetDynamicCollisionHardnessBuffAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetDynamicCollisionHardnessBuffAuthoring()
    {
      Il2CppClassPointerStore<SetDynamicCollisionHardnessBuffAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SetDynamicCollisionHardnessBuffAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetDynamicCollisionHardnessBuffAuthoring>.NativeClassPtr);
      SetDynamicCollisionHardnessBuffAuthoring.NativeFieldInfoPtr_Hardness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetDynamicCollisionHardnessBuffAuthoring>.NativeClassPtr, nameof (Hardness));
      SetDynamicCollisionHardnessBuffAuthoring.NativeFieldInfoPtr_Targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetDynamicCollisionHardnessBuffAuthoring>.NativeClassPtr, nameof (Targets));
      SetDynamicCollisionHardnessBuffAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetDynamicCollisionHardnessBuffAuthoring>.NativeClassPtr, 100680859);
      SetDynamicCollisionHardnessBuffAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetDynamicCollisionHardnessBuffAuthoring>.NativeClassPtr, 100680860);
    }

    public SetDynamicCollisionHardnessBuffAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Hardness
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetDynamicCollisionHardnessBuffAuthoring.NativeFieldInfoPtr_Hardness));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetDynamicCollisionHardnessBuffAuthoring.NativeFieldInfoPtr_Hardness)) = value;
      }
    }

    public unsafe SetDynamicCollisionHardnessBuffTargets Targets
    {
      get
      {
        return *(SetDynamicCollisionHardnessBuffTargets*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetDynamicCollisionHardnessBuffAuthoring.NativeFieldInfoPtr_Targets));
      }
      [param: In] set
      {
        *(SetDynamicCollisionHardnessBuffTargets*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetDynamicCollisionHardnessBuffAuthoring.NativeFieldInfoPtr_Targets)) = value;
      }
    }
  }
}
