// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DValues
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace StunShared.UI
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Motion2DValues
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color;
    private static readonly System.IntPtr NativeFieldInfoPtr_Alpha;
    private static readonly System.IntPtr NativeFieldInfoPtr_Scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_FillAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Size;
    private static readonly System.IntPtr NativeMethodInfoPtr_Default_Public_Static_Motion2DValues_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Motion2DValues_Motion2DValues_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Motion2DValues_Motion2DValues_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    [FieldOffset(0)]
    public Vector2 Position;
    [FieldOffset(8)]
    public float Rotation;
    [FieldOffset(12)]
    public Color Color;
    [FieldOffset(28)]
    public float Alpha;
    [FieldOffset(32)]
    public Vector2 Scale;
    [FieldOffset(40)]
    public float FillAmount;
    [FieldOffset(44)]
    public Vector2 Size;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922355, XrefRangeEnd = 922359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Motion2DValues Default()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DValues.NativeMethodInfoPtr_Default_Public_Static_Motion2DValues_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Motion2DValues*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 922361, RefRangeEnd = 922363, XrefRangeStart = 922359, XrefRangeEnd = 922361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(Motion2DValues a, Motion2DValues b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DValues.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Motion2DValues_Motion2DValues_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922363, XrefRangeEnd = 922364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(Motion2DValues a, Motion2DValues b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DValues.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Motion2DValues_Motion2DValues_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922364, XrefRangeEnd = 922368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DValues.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922368, XrefRangeEnd = 922372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DValues.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Motion2DValues()
    {
      Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Motion2DValues));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr);
      Motion2DValues.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr, nameof (Position));
      Motion2DValues.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr, nameof (Rotation));
      Motion2DValues.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr, nameof (Color));
      Motion2DValues.NativeFieldInfoPtr_Alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr, nameof (Alpha));
      Motion2DValues.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr, nameof (Scale));
      Motion2DValues.NativeFieldInfoPtr_FillAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr, nameof (FillAmount));
      Motion2DValues.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr, nameof (Size));
      Motion2DValues.NativeMethodInfoPtr_Default_Public_Static_Motion2DValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr, 100663768);
      Motion2DValues.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Motion2DValues_Motion2DValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr, 100663769);
      Motion2DValues.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Motion2DValues_Motion2DValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr, 100663770);
      Motion2DValues.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr, 100663771);
      Motion2DValues.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr, 100663772);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Motion2DValues>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
