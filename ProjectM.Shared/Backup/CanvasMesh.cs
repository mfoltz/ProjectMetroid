// Decompiled with JetBrains decompiler
// Type: CanvasMesh
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class CanvasMesh : MaskableGraphic
{
  private static readonly IntPtr NativeFieldInfoPtr_Mesh;
  private static readonly IntPtr NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0;
  private static readonly IntPtr NativeMethodInfoPtr_TransformVertex_Public_Vector3_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVertex_Public_Vector3_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714249, XrefRangeEnd = 714275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnPopulateMesh(VertexHelper vh)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vh);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CanvasMesh.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714275, XrefRangeEnd = 714290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 TransformVertex(Vector3 vertex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = (IntPtr) &vertex;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CanvasMesh.NativeMethodInfoPtr_TransformVertex_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714290, XrefRangeEnd = 714306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 InverseTransformVertex(Vector3 vertex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = (IntPtr) &vertex;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CanvasMesh.NativeMethodInfoPtr_InverseTransformVertex_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CanvasMesh()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasMesh>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CanvasMesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CanvasMesh()
  {
    Il2CppClassPointerStore<CanvasMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (CanvasMesh));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasMesh>.NativeClassPtr);
    CanvasMesh.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasMesh>.NativeClassPtr, nameof (Mesh));
    CanvasMesh.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasMesh>.NativeClassPtr, 100663338);
    CanvasMesh.NativeMethodInfoPtr_TransformVertex_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasMesh>.NativeClassPtr, 100663339);
    CanvasMesh.NativeMethodInfoPtr_InverseTransformVertex_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasMesh>.NativeClassPtr, 100663340);
    CanvasMesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasMesh>.NativeClassPtr, 100663341);
  }

  public CanvasMesh(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Mesh Mesh
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanvasMesh.NativeFieldInfoPtr_Mesh));
      return pointer == IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CanvasMesh.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
