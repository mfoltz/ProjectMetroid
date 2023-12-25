// Decompiled with JetBrains decompiler
// Type: ProjectM.AttachedDepth
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AttachedDepth
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Depth;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachedDepth_0;
    [FieldOffset(0)]
    public int Depth;

    [CallerCount(409)]
    [CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttachedDepth.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 411711, RefRangeEnd = 411739, XrefRangeStart = 411711, XrefRangeEnd = 411739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(AttachedDepth other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttachedDepth.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachedDepth_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AttachedDepth()
    {
      Il2CppClassPointerStore<AttachedDepth>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AttachedDepth));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachedDepth>.NativeClassPtr);
      AttachedDepth.NativeFieldInfoPtr_Depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachedDepth>.NativeClassPtr, nameof (Depth));
      AttachedDepth.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachedDepth>.NativeClassPtr, 100677251);
      AttachedDepth.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachedDepth_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachedDepth>.NativeClassPtr, 100677252);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttachedDepth>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
