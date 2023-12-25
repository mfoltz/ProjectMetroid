// Decompiled with JetBrains decompiler
// Type: ProjectM.AddMovementCurveEntry
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AddMovementCurveEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MovementCurves;
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddCurve_Public_Void_byref_MovementCurveEntry_byref_Int32_0;
    [FieldOffset(0)]
    public NativeList<MovementCurveEntry> MovementCurves;
    [FieldOffset(16)]
    public NativeArray<int> Id;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1001104, RefRangeEnd = 1001106, XrefRangeStart = 1001101, XrefRangeEnd = 1001104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddCurve(ref MovementCurveEntry entry, ref int id)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entry;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref id;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddMovementCurveEntry.NativeMethodInfoPtr_AddCurve_Public_Void_byref_MovementCurveEntry_byref_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AddMovementCurveEntry()
    {
      Il2CppClassPointerStore<AddMovementCurveEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AddMovementCurveEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddMovementCurveEntry>.NativeClassPtr);
      AddMovementCurveEntry.NativeFieldInfoPtr_MovementCurves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddMovementCurveEntry>.NativeClassPtr, nameof (MovementCurves));
      AddMovementCurveEntry.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddMovementCurveEntry>.NativeClassPtr, nameof (Id));
      AddMovementCurveEntry.NativeMethodInfoPtr_AddCurve_Public_Void_byref_MovementCurveEntry_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddMovementCurveEntry>.NativeClassPtr, 100677496);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddMovementCurveEntry>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
