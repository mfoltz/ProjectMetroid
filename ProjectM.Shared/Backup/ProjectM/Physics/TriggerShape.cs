// Decompiled with JetBrains decompiler
// Type: ProjectM.Physics.TriggerShape
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Physics
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TriggerShape
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_RadiusOrWidth;
    private static readonly System.IntPtr NativeFieldInfoPtr_AngleOrInnerRadiusOrHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Length;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateBox_Public_Static_TriggerShape_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateCircle_Public_Static_TriggerShape_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDonut_Public_Static_TriggerShape_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateCone_Public_Static_TriggerShape_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateCylinder_Public_Static_TriggerShape_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Cone_Radius_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Cone_Radius_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Cone_Angle_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Cone_Angle_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Box_Width_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Box_Width_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Box_Height_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Box_Height_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Box_Length_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Box_Length_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Circle_Radius_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Circle_Radius_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Donut_OuterRadius_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Donut_OuterRadius_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Donut_InnerRadius_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Donut_InnerRadius_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Cylinder_Radius_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Cylinder_Radius_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Cylinder_Height_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Cylinder_Height_Public_set_Void_Single_0;
    [FieldOffset(0)]
    public TriggerShapeType Type;
    [FieldOffset(4)]
    public float RadiusOrWidth;
    [FieldOffset(8)]
    public float AngleOrInnerRadiusOrHeight;
    [FieldOffset(12)]
    public float Length;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769684, RefRangeEnd = 769685, XrefRangeStart = 769684, XrefRangeEnd = 769684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TriggerShape CreateBox(float width, float height, float length)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &width;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_CreateBox_Public_Static_TriggerShape_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TriggerShape*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769685, RefRangeEnd = 769686, XrefRangeStart = 769685, XrefRangeEnd = 769685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TriggerShape CreateCircle(float radius)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &radius;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_CreateCircle_Public_Static_TriggerShape_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TriggerShape*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769686, RefRangeEnd = 769687, XrefRangeStart = 769686, XrefRangeEnd = 769686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TriggerShape CreateDonut(float outerRadius, float innerRadius)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &outerRadius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &innerRadius;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_CreateDonut_Public_Static_TriggerShape_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TriggerShape*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769687, RefRangeEnd = 769688, XrefRangeStart = 769687, XrefRangeEnd = 769687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TriggerShape CreateCone(float radius, float angle)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_CreateCone_Public_Static_TriggerShape_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TriggerShape*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769688, RefRangeEnd = 769689, XrefRangeStart = 769688, XrefRangeEnd = 769688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TriggerShape CreateCylinder(float radius, float height)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_CreateCylinder_Public_Static_TriggerShape_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TriggerShape*) IL2CPP.il2cpp_object_unbox(num);
    }

    public unsafe float Cone_Radius
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_get_Cone_Radius_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 195834, RefRangeEnd = 195854, XrefRangeStart = 195834, XrefRangeEnd = 195854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_set_Cone_Radius_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float Cone_Angle
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_get_Cone_Angle_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 195993, RefRangeEnd = 196007, XrefRangeStart = 195993, XrefRangeEnd = 196007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_set_Cone_Angle_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float Box_Width
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_get_Box_Width_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 195834, RefRangeEnd = 195854, XrefRangeStart = 195834, XrefRangeEnd = 195854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_set_Box_Width_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float Box_Height
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_get_Box_Height_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 195993, RefRangeEnd = 196007, XrefRangeStart = 195993, XrefRangeEnd = 196007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_set_Box_Height_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float Box_Length
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 322188, RefRangeEnd = 322209, XrefRangeStart = 322188, XrefRangeEnd = 322209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_get_Box_Length_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 196182, RefRangeEnd = 196202, XrefRangeStart = 196182, XrefRangeEnd = 196202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_set_Box_Length_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float Circle_Radius
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_get_Circle_Radius_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 195834, RefRangeEnd = 195854, XrefRangeStart = 195834, XrefRangeEnd = 195854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_set_Circle_Radius_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float Donut_OuterRadius
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_get_Donut_OuterRadius_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 195834, RefRangeEnd = 195854, XrefRangeStart = 195834, XrefRangeEnd = 195854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_set_Donut_OuterRadius_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float Donut_InnerRadius
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_get_Donut_InnerRadius_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 195993, RefRangeEnd = 196007, XrefRangeStart = 195993, XrefRangeEnd = 196007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_set_Donut_InnerRadius_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float Cylinder_Radius
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_get_Cylinder_Radius_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 195834, RefRangeEnd = 195854, XrefRangeStart = 195834, XrefRangeEnd = 195854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_set_Cylinder_Radius_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float Cylinder_Height
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_get_Cylinder_Height_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 195993, RefRangeEnd = 196007, XrefRangeStart = 195993, XrefRangeEnd = 196007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerShape.NativeMethodInfoPtr_set_Cylinder_Height_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static TriggerShape()
    {
      Il2CppClassPointerStore<TriggerShape>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Physics", nameof (TriggerShape));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr);
      TriggerShape.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, nameof (Type));
      TriggerShape.NativeFieldInfoPtr_RadiusOrWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, nameof (RadiusOrWidth));
      TriggerShape.NativeFieldInfoPtr_AngleOrInnerRadiusOrHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, nameof (AngleOrInnerRadiusOrHeight));
      TriggerShape.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, nameof (Length));
      TriggerShape.NativeMethodInfoPtr_CreateBox_Public_Static_TriggerShape_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668099);
      TriggerShape.NativeMethodInfoPtr_CreateCircle_Public_Static_TriggerShape_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668100);
      TriggerShape.NativeMethodInfoPtr_CreateDonut_Public_Static_TriggerShape_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668101);
      TriggerShape.NativeMethodInfoPtr_CreateCone_Public_Static_TriggerShape_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668102);
      TriggerShape.NativeMethodInfoPtr_CreateCylinder_Public_Static_TriggerShape_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668103);
      TriggerShape.NativeMethodInfoPtr_get_Cone_Radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668104);
      TriggerShape.NativeMethodInfoPtr_set_Cone_Radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668105);
      TriggerShape.NativeMethodInfoPtr_get_Cone_Angle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668106);
      TriggerShape.NativeMethodInfoPtr_set_Cone_Angle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668107);
      TriggerShape.NativeMethodInfoPtr_get_Box_Width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668108);
      TriggerShape.NativeMethodInfoPtr_set_Box_Width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668109);
      TriggerShape.NativeMethodInfoPtr_get_Box_Height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668110);
      TriggerShape.NativeMethodInfoPtr_set_Box_Height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668111);
      TriggerShape.NativeMethodInfoPtr_get_Box_Length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668112);
      TriggerShape.NativeMethodInfoPtr_set_Box_Length_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668113);
      TriggerShape.NativeMethodInfoPtr_get_Circle_Radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668114);
      TriggerShape.NativeMethodInfoPtr_set_Circle_Radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668115);
      TriggerShape.NativeMethodInfoPtr_get_Donut_OuterRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668116);
      TriggerShape.NativeMethodInfoPtr_set_Donut_OuterRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668117);
      TriggerShape.NativeMethodInfoPtr_get_Donut_InnerRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668118);
      TriggerShape.NativeMethodInfoPtr_set_Donut_InnerRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668119);
      TriggerShape.NativeMethodInfoPtr_get_Cylinder_Radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668120);
      TriggerShape.NativeMethodInfoPtr_set_Cylinder_Radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668121);
      TriggerShape.NativeMethodInfoPtr_get_Cylinder_Height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668122);
      TriggerShape.NativeMethodInfoPtr_set_Cylinder_Height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, 100668123);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TriggerShape>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
