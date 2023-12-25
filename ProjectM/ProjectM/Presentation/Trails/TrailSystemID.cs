// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.Trails.TrailSystemID
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Presentation.Trails
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TrailSystemID
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    private static readonly System.IntPtr NativeFieldInfoPtr_Generation;
    private static readonly System.IntPtr NativeFieldInfoPtr_None;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TrailSystemID_TrailSystemID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TrailSystemID_TrailSystemID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TrailSystemID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public int Index;
    [FieldOffset(4)]
    public int Generation;

    [CallerCount(658)]
    [CachedScanResults(RefRangeStart = 410500, RefRangeEnd = 411158, XrefRangeStart = 410500, XrefRangeEnd = 411158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(TrailSystemID a, TrailSystemID b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TrailSystemID_TrailSystemID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1113804, RefRangeEnd = 1113811, XrefRangeStart = 1113801, XrefRangeEnd = 1113804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(TrailSystemID a, TrailSystemID b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TrailSystemID_TrailSystemID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113811, XrefRangeEnd = 1113815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1113818, RefRangeEnd = 1113819, XrefRangeStart = 1113815, XrefRangeEnd = 1113818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(TrailSystemID other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TrailSystemID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 727621, RefRangeEnd = 727622, XrefRangeStart = 727621, XrefRangeEnd = 727622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113819, XrefRangeEnd = 1113825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TrailSystemID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static TrailSystemID()
    {
      Il2CppClassPointerStore<TrailSystemID>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation.Trails", nameof (TrailSystemID));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailSystemID>.NativeClassPtr);
      TrailSystemID.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemID>.NativeClassPtr, nameof (Index));
      TrailSystemID.NativeFieldInfoPtr_Generation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemID>.NativeClassPtr, nameof (Generation));
      TrailSystemID.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemID>.NativeClassPtr, nameof (None));
      TrailSystemID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TrailSystemID_TrailSystemID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemID>.NativeClassPtr, 100688156);
      TrailSystemID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TrailSystemID_TrailSystemID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemID>.NativeClassPtr, 100688157);
      TrailSystemID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemID>.NativeClassPtr, 100688158);
      TrailSystemID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TrailSystemID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemID>.NativeClassPtr, 100688159);
      TrailSystemID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemID>.NativeClassPtr, 100688160);
      TrailSystemID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemID>.NativeClassPtr, 100688161);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrailSystemID>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe TrailSystemID None
    {
      get
      {
        TrailSystemID none;
        IL2CPP.il2cpp_field_static_get_value(TrailSystemID.NativeFieldInfoPtr_None, (void*) &none);
        return none;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TrailSystemID.NativeFieldInfoPtr_None, (void*) &value);
      }
    }
  }
}
