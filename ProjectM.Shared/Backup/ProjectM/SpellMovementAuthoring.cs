// Decompiled with JetBrains decompiler
// Type: ProjectM.SpellMovementAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class SpellMovementAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_CurveXLoops;
    private static readonly IntPtr NativeFieldInfoPtr_CurveX;
    private static readonly IntPtr NativeFieldInfoPtr_XScale;
    private static readonly IntPtr NativeFieldInfoPtr_CurveY;
    private static readonly IntPtr NativeFieldInfoPtr_YScale;
    private static readonly IntPtr NativeFieldInfoPtr_CurveZ;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726986, XrefRangeEnd = 726989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(SpellMovementAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726989, XrefRangeEnd = 726999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpellMovementAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726999, XrefRangeEnd = 727000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellMovementAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellMovementAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellMovementAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellMovementAuthoring()
    {
      Il2CppClassPointerStore<SpellMovementAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpellMovementAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellMovementAuthoring>.NativeClassPtr);
      SpellMovementAuthoring.NativeFieldInfoPtr_CurveXLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovementAuthoring>.NativeClassPtr, nameof (CurveXLoops));
      SpellMovementAuthoring.NativeFieldInfoPtr_CurveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovementAuthoring>.NativeClassPtr, nameof (CurveX));
      SpellMovementAuthoring.NativeFieldInfoPtr_XScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovementAuthoring>.NativeClassPtr, nameof (XScale));
      SpellMovementAuthoring.NativeFieldInfoPtr_CurveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovementAuthoring>.NativeClassPtr, nameof (CurveY));
      SpellMovementAuthoring.NativeFieldInfoPtr_YScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovementAuthoring>.NativeClassPtr, nameof (YScale));
      SpellMovementAuthoring.NativeFieldInfoPtr_CurveZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovementAuthoring>.NativeClassPtr, nameof (CurveZ));
      SpellMovementAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellMovementAuthoring>.NativeClassPtr, 100664290);
      SpellMovementAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellMovementAuthoring>.NativeClassPtr, 100664291);
      SpellMovementAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellMovementAuthoring>.NativeClassPtr, 100664292);
    }

    public SpellMovementAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float CurveXLoops
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellMovementAuthoring.NativeFieldInfoPtr_CurveXLoops));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellMovementAuthoring.NativeFieldInfoPtr_CurveXLoops)) = value;
      }
    }

    public unsafe CurveReference CurveX
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellMovementAuthoring.NativeFieldInfoPtr_CurveX));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellMovementAuthoring.NativeFieldInfoPtr_CurveX)) = value;
      }
    }

    public unsafe float XScale
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellMovementAuthoring.NativeFieldInfoPtr_XScale));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellMovementAuthoring.NativeFieldInfoPtr_XScale)) = value;
      }
    }

    public unsafe CurveReference CurveY
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellMovementAuthoring.NativeFieldInfoPtr_CurveY));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellMovementAuthoring.NativeFieldInfoPtr_CurveY)) = value;
      }
    }

    public unsafe float YScale
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellMovementAuthoring.NativeFieldInfoPtr_YScale));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellMovementAuthoring.NativeFieldInfoPtr_YScale)) = value;
      }
    }

    public unsafe CurveReference CurveZ
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellMovementAuthoring.NativeFieldInfoPtr_CurveZ));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellMovementAuthoring.NativeFieldInfoPtr_CurveZ)) = value;
      }
    }
  }
}
