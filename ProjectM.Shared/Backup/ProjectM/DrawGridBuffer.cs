// Decompiled with JetBrains decompiler
// Type: ProjectM.DrawGridBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DrawGridBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_DrawGridBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DrawGridBuffer_Color32_0;
    [FieldOffset(0)]
    public Color32 Value;

    [CallerCount(504)]
    [CachedScanResults(RefRangeStart = 279526, RefRangeEnd = 280030, XrefRangeStart = 279526, XrefRangeEnd = 280030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator Color32(DrawGridBuffer e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawGridBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_DrawGridBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color32*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(504)]
    [CachedScanResults(RefRangeStart = 279526, RefRangeEnd = 280030, XrefRangeStart = 279526, XrefRangeEnd = 280030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator DrawGridBuffer(Color32 e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawGridBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_DrawGridBuffer_Color32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DrawGridBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DrawGridBuffer()
    {
      Il2CppClassPointerStore<DrawGridBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DrawGridBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawGridBuffer>.NativeClassPtr);
      DrawGridBuffer.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawGridBuffer>.NativeClassPtr, nameof (Value));
      DrawGridBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_DrawGridBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawGridBuffer>.NativeClassPtr, 100664812);
      DrawGridBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_DrawGridBuffer_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawGridBuffer>.NativeClassPtr, 100664813);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawGridBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
