// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModArithmeticOperationExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  public static class SpellModArithmeticOperationExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Operate_Public_Static_Void_SpellModArithmeticOperation_byref_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Operate_Public_Static_ModificationId_SpellModArithmeticOperation_byref_ModifiableFloat_Single_byref_SpellModArithmeticModifiableOperationData_0;

    [CallerCount(27)]
    [CachedScanResults(RefRangeStart = 798466, RefRangeEnd = 798493, XrefRangeStart = 798466, XrefRangeEnd = 798466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Operate(
      this SpellModArithmeticOperation operation,
      ref float baseValue,
      float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref baseValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModArithmeticOperationExtensions.NativeMethodInfoPtr_Operate_Public_Static_Void_SpellModArithmeticOperation_byref_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 798503, RefRangeEnd = 798509, XrefRangeStart = 798493, XrefRangeEnd = 798503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModificationId Operate(
      this SpellModArithmeticOperation operation,
      ref ModifiableFloat modifiable,
      float value,
      [In] ref SpellModArithmeticModifiableOperationData operationData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifiable;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref operationData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModArithmeticOperationExtensions.NativeMethodInfoPtr_Operate_Public_Static_ModificationId_SpellModArithmeticOperation_byref_ModifiableFloat_Single_byref_SpellModArithmeticModifiableOperationData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpellModArithmeticOperationExtensions()
    {
      Il2CppClassPointerStore<SpellModArithmeticOperationExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModArithmeticOperationExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModArithmeticOperationExtensions>.NativeClassPtr);
      SpellModArithmeticOperationExtensions.NativeMethodInfoPtr_Operate_Public_Static_Void_SpellModArithmeticOperation_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModArithmeticOperationExtensions>.NativeClassPtr, 100670402);
      SpellModArithmeticOperationExtensions.NativeMethodInfoPtr_Operate_Public_Static_ModificationId_SpellModArithmeticOperation_byref_ModifiableFloat_Single_byref_SpellModArithmeticModifiableOperationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModArithmeticOperationExtensions>.NativeClassPtr, 100670403);
    }

    public SpellModArithmeticOperationExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
