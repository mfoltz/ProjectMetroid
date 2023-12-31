// Decompiled with JetBrains decompiler
// Type: ProjectM.LineTraversalChunkContext`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Terrain;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public struct LineTraversalChunkContext<T>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkBounds_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentChunkEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainChunks;
    private static readonly System.IntPtr NativeFieldInfoPtr__BufferAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentChunkBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr__HasBuffer;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ChunkBounds_Public_get_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ChunkBounds_Private_set_Void_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BufferFromEntity_1_T_TerrainChunkLookup_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Step_Public_T_int2_0;
    public BoundsMinMax _ChunkBounds_k__BackingField;
    public Entity _CurrentChunkEntity;
    public readonly TerrainChunkLookup _TerrainChunks;
    public BufferFromEntity<T> _BufferAccessor;
    public NativeArray<T> _CurrentChunkBuffer;
    public bool _HasBuffer;

    public unsafe BoundsMinMax ChunkBounds
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineTraversalChunkContext<T>.NativeMethodInfoPtr_get_ChunkBounds_Public_get_BoundsMinMax_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LineTraversalChunkContext<T>.NativeMethodInfoPtr_set_ChunkBounds_Private_set_Void_BoundsMinMax_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    public unsafe LineTraversalChunkContext(
      BufferFromEntity<T> bufferAccessor,
      TerrainChunkLookup terrainChunks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &bufferAccessor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &terrainChunks;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LineTraversalChunkContext<T>.NativeMethodInfoPtr__ctor_Public_Void_BufferFromEntity_1_T_TerrainChunkLookup_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe T Step(int2 worldTile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldTile;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(LineTraversalChunkContext<T>.NativeMethodInfoPtr_Step_Public_T_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    static LineTraversalChunkContext()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<LineTraversalChunkContext<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", "LineTraversalChunkContext`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineTraversalChunkContext<T>>.NativeClassPtr);
      LineTraversalChunkContext<T>.NativeFieldInfoPtr__ChunkBounds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversalChunkContext<T>>.NativeClassPtr, "<ChunkBounds>k__BackingField");
      LineTraversalChunkContext<T>.NativeFieldInfoPtr__CurrentChunkEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversalChunkContext<T>>.NativeClassPtr, nameof (_CurrentChunkEntity));
      LineTraversalChunkContext<T>.NativeFieldInfoPtr__TerrainChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversalChunkContext<T>>.NativeClassPtr, nameof (_TerrainChunks));
      LineTraversalChunkContext<T>.NativeFieldInfoPtr__BufferAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversalChunkContext<T>>.NativeClassPtr, nameof (_BufferAccessor));
      LineTraversalChunkContext<T>.NativeFieldInfoPtr__CurrentChunkBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversalChunkContext<T>>.NativeClassPtr, nameof (_CurrentChunkBuffer));
      LineTraversalChunkContext<T>.NativeFieldInfoPtr__HasBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineTraversalChunkContext<T>>.NativeClassPtr, nameof (_HasBuffer));
      LineTraversalChunkContext<T>.NativeMethodInfoPtr_get_ChunkBounds_Public_get_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineTraversalChunkContext<T>>.NativeClassPtr, 100667558);
      LineTraversalChunkContext<T>.NativeMethodInfoPtr_set_ChunkBounds_Private_set_Void_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineTraversalChunkContext<T>>.NativeClassPtr, 100667559);
      LineTraversalChunkContext<T>.NativeMethodInfoPtr__ctor_Public_Void_BufferFromEntity_1_T_TerrainChunkLookup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineTraversalChunkContext<T>>.NativeClassPtr, 100667560);
      LineTraversalChunkContext<T>.NativeMethodInfoPtr_Step_Public_T_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineTraversalChunkContext<T>>.NativeClassPtr, 100667561);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LineTraversalChunkContext<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
