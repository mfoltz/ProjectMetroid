// Decompiled with JetBrains decompiler
// Type: ProjectM.ProfessorCoilPairElement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ProfessorCoilPairElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CoilIndex0;
    private static readonly System.IntPtr NativeFieldInfoPtr_CoilIndex1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ProfessorCoilPairElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_Int32_Int32_Int32_Int32_0;
    [FieldOffset(0)]
    public int CoilIndex0;
    [FieldOffset(4)]
    public int CoilIndex1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996243, XrefRangeEnd = 996246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilPairElement.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996246, XrefRangeEnd = 996248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilPairElement.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool Equals(ProfessorCoilPairElement other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilPairElement.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ProfessorCoilPairElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 996248, RefRangeEnd = 996249, XrefRangeStart = 996248, XrefRangeEnd = 996248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Equals(
      int coil0Index0,
      int coil0Index1,
      int coil1Index0,
      int coil1Index1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &coil0Index0;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &coil0Index1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &coil1Index0;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &coil1Index1;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilPairElement.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ProfessorCoilPairElement()
    {
      Il2CppClassPointerStore<ProfessorCoilPairElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProfessorCoilPairElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilPairElement>.NativeClassPtr);
      ProfessorCoilPairElement.NativeFieldInfoPtr_CoilIndex0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilPairElement>.NativeClassPtr, nameof (CoilIndex0));
      ProfessorCoilPairElement.NativeFieldInfoPtr_CoilIndex1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilPairElement>.NativeClassPtr, nameof (CoilIndex1));
      ProfessorCoilPairElement.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilPairElement>.NativeClassPtr, 100676983);
      ProfessorCoilPairElement.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilPairElement>.NativeClassPtr, 100676984);
      ProfessorCoilPairElement.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ProfessorCoilPairElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilPairElement>.NativeClassPtr, 100676985);
      ProfessorCoilPairElement.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilPairElement>.NativeClassPtr, 100676986);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilPairElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
