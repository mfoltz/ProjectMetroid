// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.GetLayerTilesDelegate
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace ProjectM.Tiles
{
  public sealed class GetLayerTilesDelegate : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TileLayer_byref_ptr_Void_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TileLayer_byref_ptr_Void_byref_Int32_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ptr_Void_byref_Int32_IAsyncResult_0;

    [CallerCount(5227)]
    [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GetLayerTilesDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetLayerTilesDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetLayerTilesDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Invoke(TileLayer layer, out void* arrayPointer, out int elementSize)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &layer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayPointer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref elementSize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetLayerTilesDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TileLayer_byref_ptr_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792796, XrefRangeEnd = 792803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      TileLayer layer,
      out void* arrayPointer,
      out int elementSize,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &layer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayPointer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref elementSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetLayerTilesDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TileLayer_byref_ptr_Void_byref_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void EndInvoke(
      out void* arrayPointer,
      out int elementSize,
      Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref arrayPointer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref elementSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetLayerTilesDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ptr_Void_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GetLayerTilesDelegate()
    {
      Il2CppClassPointerStore<GetLayerTilesDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (GetLayerTilesDelegate));
      GetLayerTilesDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLayerTilesDelegate>.NativeClassPtr, 100669802);
      GetLayerTilesDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TileLayer_byref_ptr_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLayerTilesDelegate>.NativeClassPtr, 100669803);
      GetLayerTilesDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TileLayer_byref_ptr_Void_byref_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLayerTilesDelegate>.NativeClassPtr, 100669804);
      GetLayerTilesDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ptr_Void_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLayerTilesDelegate>.NativeClassPtr, 100669805);
    }

    public GetLayerTilesDelegate(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
