// Decompiled with JetBrains decompiler
// Type: ProjectM.AiMoveSpeedsAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

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
  public class AiMoveSpeedsAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Walk;
    private static readonly IntPtr NativeFieldInfoPtr_Run;
    private static readonly IntPtr NativeFieldInfoPtr_Circle;
    private static readonly IntPtr NativeFieldInfoPtr_Return;
    private static readonly IntPtr NativeFieldInfoPtr_Variation;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723038, XrefRangeEnd = 723041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AiMoveSpeedsAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AiMoveSpeedsAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AiMoveSpeedsAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMoveSpeedsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AiMoveSpeedsAuthoring()
    {
      Il2CppClassPointerStore<AiMoveSpeedsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AiMoveSpeedsAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSpeedsAuthoring>.NativeClassPtr);
      AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Walk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSpeedsAuthoring>.NativeClassPtr, nameof (Walk));
      AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Run = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSpeedsAuthoring>.NativeClassPtr, nameof (Run));
      AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSpeedsAuthoring>.NativeClassPtr, nameof (Circle));
      AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Return = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSpeedsAuthoring>.NativeClassPtr, nameof (Return));
      AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Variation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSpeedsAuthoring>.NativeClassPtr, nameof (Variation));
      AiMoveSpeedsAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSpeedsAuthoring>.NativeClassPtr, 100663886);
      AiMoveSpeedsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSpeedsAuthoring>.NativeClassPtr, 100663887);
    }

    public AiMoveSpeedsAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Walk
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Walk));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Walk)) = value;
      }
    }

    public unsafe float Run
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Run));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Run)) = value;
      }
    }

    public unsafe float Circle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Circle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Circle)) = value;
      }
    }

    public unsafe float Return
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Return));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Return)) = value;
      }
    }

    public unsafe float Variation
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Variation));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSpeedsAuthoring.NativeFieldInfoPtr_Variation)) = value;
      }
    }
  }
}
