// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.ModelDrawer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.StunDebug
{
  public class ModelDrawer : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CAMERA_EVENT;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModelsToDraw;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommandBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr__Block;
    private static readonly System.IntPtr NativeFieldInfoPtr__Cameras;
    private static readonly System.IntPtr NativeMethodInfoPtr_CleanUp_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Public_Void_Camera_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawSphere_Public_Void_Vector3_Single_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireSphere_Public_Void_Vector3_Single_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawCube_Public_Void_Vector3_Vector3_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawModels_Private_Void_List_1_ModelData_Camera_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771401, RefRangeEnd = 771402, XrefRangeStart = 771376, XrefRangeEnd = 771401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CleanUp()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModelDrawer.NativeMethodInfoPtr_CleanUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771403, RefRangeEnd = 771404, XrefRangeStart = 771402, XrefRangeEnd = 771403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Draw(Camera camera)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModelDrawer.NativeMethodInfoPtr_Draw_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771409, RefRangeEnd = 771410, XrefRangeStart = 771404, XrefRangeEnd = 771409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawSphere(Vector3 position, float radius, Color color)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModelDrawer.NativeMethodInfoPtr_DrawSphere_Public_Void_Vector3_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771410, XrefRangeEnd = 771415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawWireSphere(Vector3 position, float radius, Color color)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModelDrawer.NativeMethodInfoPtr_DrawWireSphere_Public_Void_Vector3_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771419, RefRangeEnd = 771420, XrefRangeStart = 771415, XrefRangeEnd = 771419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawCube(Vector3 position, Vector3 scale, Color color)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModelDrawer.NativeMethodInfoPtr_DrawCube_Public_Void_Vector3_Vector3_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771489, RefRangeEnd = 771490, XrefRangeStart = 771420, XrefRangeEnd = 771489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawModels(List<ModelDrawer.ModelData> drawData, Camera camera)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) drawData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModelDrawer.NativeMethodInfoPtr_DrawModels_Private_Void_List_1_ModelData_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 771505, RefRangeEnd = 771506, XrefRangeStart = 771490, XrefRangeEnd = 771505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModelDrawer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModelDrawer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModelDrawer()
    {
      Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", nameof (ModelDrawer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr);
      ModelDrawer.NativeFieldInfoPtr_CAMERA_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr, nameof (CAMERA_EVENT));
      ModelDrawer.NativeFieldInfoPtr__ModelsToDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr, nameof (_ModelsToDraw));
      ModelDrawer.NativeFieldInfoPtr__CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr, nameof (_CommandBuffer));
      ModelDrawer.NativeFieldInfoPtr__Block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr, nameof (_Block));
      ModelDrawer.NativeFieldInfoPtr__Cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr, nameof (_Cameras));
      ModelDrawer.NativeMethodInfoPtr_CleanUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr, 100668324);
      ModelDrawer.NativeMethodInfoPtr_Draw_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr, 100668325);
      ModelDrawer.NativeMethodInfoPtr_DrawSphere_Public_Void_Vector3_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr, 100668326);
      ModelDrawer.NativeMethodInfoPtr_DrawWireSphere_Public_Void_Vector3_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr, 100668327);
      ModelDrawer.NativeMethodInfoPtr_DrawCube_Public_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr, 100668328);
      ModelDrawer.NativeMethodInfoPtr_DrawModels_Private_Void_List_1_ModelData_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr, 100668329);
      ModelDrawer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr, 100668330);
    }

    public ModelDrawer(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CameraEvent CAMERA_EVENT
    {
      get
      {
        CameraEvent cameraEvent;
        IL2CPP.il2cpp_field_static_get_value(ModelDrawer.NativeFieldInfoPtr_CAMERA_EVENT, (void*) &cameraEvent);
        return cameraEvent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ModelDrawer.NativeFieldInfoPtr_CAMERA_EVENT, (void*) &value);
      }
    }

    public unsafe List<ModelDrawer.ModelData> _ModelsToDraw
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModelDrawer.NativeFieldInfoPtr__ModelsToDraw));
        return pointer == System.IntPtr.Zero ? (List<ModelDrawer.ModelData>) null : new List<ModelDrawer.ModelData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModelDrawer.NativeFieldInfoPtr__ModelsToDraw), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommandBuffer _CommandBuffer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModelDrawer.NativeFieldInfoPtr__CommandBuffer));
        return pointer == System.IntPtr.Zero ? (CommandBuffer) null : new CommandBuffer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModelDrawer.NativeFieldInfoPtr__CommandBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MaterialPropertyBlock _Block
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModelDrawer.NativeFieldInfoPtr__Block));
        return pointer == System.IntPtr.Zero ? (MaterialPropertyBlock) null : new MaterialPropertyBlock(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModelDrawer.NativeFieldInfoPtr__Block), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Camera> _Cameras
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModelDrawer.NativeFieldInfoPtr__Cameras));
        return pointer == System.IntPtr.Zero ? (List<Camera>) null : new List<Camera>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModelDrawer.NativeFieldInfoPtr__Cameras), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum ModelEnum
    {
      Sphere,
      WireSphere,
      Cube,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ModelData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Model;
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_Scale;
      private static readonly System.IntPtr NativeFieldInfoPtr_Color;
      [FieldOffset(0)]
      public ModelDrawer.ModelEnum Model;
      [FieldOffset(4)]
      public Vector3 Position;
      [FieldOffset(16)]
      public Quaternion Rotation;
      [FieldOffset(32)]
      public Vector3 Scale;
      [FieldOffset(44)]
      public Color Color;

      static ModelData()
      {
        Il2CppClassPointerStore<ModelDrawer.ModelData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModelDrawer>.NativeClassPtr, nameof (ModelData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelDrawer.ModelData>.NativeClassPtr);
        ModelDrawer.ModelData.NativeFieldInfoPtr_Model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDrawer.ModelData>.NativeClassPtr, nameof (Model));
        ModelDrawer.ModelData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDrawer.ModelData>.NativeClassPtr, nameof (Position));
        ModelDrawer.ModelData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDrawer.ModelData>.NativeClassPtr, nameof (Rotation));
        ModelDrawer.ModelData.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDrawer.ModelData>.NativeClassPtr, nameof (Scale));
        ModelDrawer.ModelData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDrawer.ModelData>.NativeClassPtr, nameof (Color));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModelDrawer.ModelData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
