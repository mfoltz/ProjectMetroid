// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.VectorExtensions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public static class VectorExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ToVector2_Public_Static_Vector2_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToVector3_Public_Static_Vector3_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToInt2_Public_Static_int2_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToInt3_Public_Static_int3_Vector2_0;

    [CallerCount(0)]
    public static unsafe Vector2 ToVector2(this int2 input)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &input;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VectorExtensions.NativeMethodInfoPtr_ToVector2_Public_Static_Vector2_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe Vector3 ToVector3(this int2 input)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &input;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VectorExtensions.NativeMethodInfoPtr_ToVector3_Public_Static_Vector3_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe int2 ToInt2(this Vector2 input)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &input;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VectorExtensions.NativeMethodInfoPtr_ToInt2_Public_Static_int2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe int3 ToInt3(this Vector2 input)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &input;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VectorExtensions.NativeMethodInfoPtr_ToInt3_Public_Static_int3_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int3*) IL2CPP.il2cpp_object_unbox(num);
    }

    static VectorExtensions()
    {
      Il2CppClassPointerStore<VectorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (VectorExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorExtensions>.NativeClassPtr);
      VectorExtensions.NativeMethodInfoPtr_ToVector2_Public_Static_Vector2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorExtensions>.NativeClassPtr, 100687205);
      VectorExtensions.NativeMethodInfoPtr_ToVector3_Public_Static_Vector3_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorExtensions>.NativeClassPtr, 100687206);
      VectorExtensions.NativeMethodInfoPtr_ToInt2_Public_Static_int2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorExtensions>.NativeClassPtr, 100687207);
      VectorExtensions.NativeMethodInfoPtr_ToInt3_Public_Static_int3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorExtensions>.NativeClassPtr, 100687208);
    }

    public VectorExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
