// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PlayerDataStorage.OnWriteFileDataCallback
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices.PlayerDataStorage
{
  public sealed class OnWriteFileDataCallback : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_WriteResult_byref_WriteFileDataCallbackInfo_byref_ArraySegment_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_WriteFileDataCallbackInfo_byref_ArraySegment_1_Byte_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_WriteResult_byref_WriteFileDataCallbackInfo_byref_ArraySegment_1_Byte_IAsyncResult_0;

    [CallerCount(5227)]
    [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnWriteFileDataCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnWriteFileDataCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnWriteFileDataCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe WriteResult Invoke(
      ref WriteFileDataCallbackInfo data,
      out Il2CppSystem.ArraySegment<byte> outDataBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnWriteFileDataCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_WriteResult_byref_WriteFileDataCallbackInfo_byref_ArraySegment_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.ArraySegment<byte> local = ref outDataBuffer;
      System.IntPtr pointer = zero;
      Il2CppSystem.ArraySegment<> arraySegment = pointer == System.IntPtr.Zero ? (Il2CppSystem.ArraySegment<>) null : new Il2CppSystem.ArraySegment<>(pointer);
      local = (Il2CppSystem.ArraySegment<byte>) arraySegment;
      return *(WriteResult*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949782, XrefRangeEnd = 949789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      ref WriteFileDataCallbackInfo data,
      out Il2CppSystem.ArraySegment<byte> outDataBuffer,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnWriteFileDataCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_WriteFileDataCallbackInfo_byref_ArraySegment_1_Byte_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.ArraySegment<byte> local = ref outDataBuffer;
      System.IntPtr pointer1 = zero;
      Il2CppSystem.ArraySegment<> arraySegment = pointer1 == System.IntPtr.Zero ? (Il2CppSystem.ArraySegment<>) null : new Il2CppSystem.ArraySegment<>(pointer1);
      local = (Il2CppSystem.ArraySegment<byte>) arraySegment;
      System.IntPtr pointer2 = num2;
      return pointer2 == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe WriteResult EndInvoke(
      ref WriteFileDataCallbackInfo data,
      out Il2CppSystem.ArraySegment<byte> outDataBuffer,
      Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnWriteFileDataCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_WriteResult_byref_WriteFileDataCallbackInfo_byref_ArraySegment_1_Byte_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.ArraySegment<byte> local = ref outDataBuffer;
      System.IntPtr pointer = zero;
      Il2CppSystem.ArraySegment<> arraySegment = pointer == System.IntPtr.Zero ? (Il2CppSystem.ArraySegment<>) null : new Il2CppSystem.ArraySegment<>(pointer);
      local = (Il2CppSystem.ArraySegment<byte>) arraySegment;
      return *(WriteResult*) IL2CPP.il2cpp_object_unbox(num2);
    }

    static OnWriteFileDataCallback()
    {
      Il2CppClassPointerStore<OnWriteFileDataCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.PlayerDataStorage", nameof (OnWriteFileDataCallback));
      OnWriteFileDataCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnWriteFileDataCallback>.NativeClassPtr, 100668596);
      OnWriteFileDataCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_WriteResult_byref_WriteFileDataCallbackInfo_byref_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnWriteFileDataCallback>.NativeClassPtr, 100668597);
      OnWriteFileDataCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_WriteFileDataCallbackInfo_byref_ArraySegment_1_Byte_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnWriteFileDataCallback>.NativeClassPtr, 100668598);
      OnWriteFileDataCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_WriteResult_byref_WriteFileDataCallbackInfo_byref_ArraySegment_1_Byte_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnWriteFileDataCallback>.NativeClassPtr, 100668599);
    }

    public OnWriteFileDataCallback(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
