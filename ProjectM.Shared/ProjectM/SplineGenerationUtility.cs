// Decompiled with JetBrains decompiler
// Type: ProjectM.SplineGenerationUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class SplineGenerationUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ModuleMeshExportPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModuleParentName;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxCurveMatchingFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxIterationsPerSpline;
    private static readonly System.IntPtr NativeFieldInfoPtr_FuturePredictionIterations;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumStepsBezierLengthMeasure;

    static SplineGenerationUtility()
    {
      Il2CppClassPointerStore<SplineGenerationUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SplineGenerationUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplineGenerationUtility>.NativeClassPtr);
      SplineGenerationUtility.NativeFieldInfoPtr_ModuleMeshExportPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineGenerationUtility>.NativeClassPtr, nameof (ModuleMeshExportPath));
      SplineGenerationUtility.NativeFieldInfoPtr_ModuleParentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineGenerationUtility>.NativeClassPtr, nameof (ModuleParentName));
      SplineGenerationUtility.NativeFieldInfoPtr_MaxCurveMatchingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineGenerationUtility>.NativeClassPtr, nameof (MaxCurveMatchingFactor));
      SplineGenerationUtility.NativeFieldInfoPtr_MaxIterationsPerSpline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineGenerationUtility>.NativeClassPtr, nameof (MaxIterationsPerSpline));
      SplineGenerationUtility.NativeFieldInfoPtr_FuturePredictionIterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineGenerationUtility>.NativeClassPtr, nameof (FuturePredictionIterations));
      SplineGenerationUtility.NativeFieldInfoPtr_NumStepsBezierLengthMeasure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineGenerationUtility>.NativeClassPtr, nameof (NumStepsBezierLengthMeasure));
    }

    public SplineGenerationUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string ModuleMeshExportPath
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(SplineGenerationUtility.NativeFieldInfoPtr_ModuleMeshExportPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SplineGenerationUtility.NativeFieldInfoPtr_ModuleMeshExportPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ModuleParentName
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(SplineGenerationUtility.NativeFieldInfoPtr_ModuleParentName, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SplineGenerationUtility.NativeFieldInfoPtr_ModuleParentName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe float MaxCurveMatchingFactor
    {
      get
      {
        float curveMatchingFactor;
        IL2CPP.il2cpp_field_static_get_value(SplineGenerationUtility.NativeFieldInfoPtr_MaxCurveMatchingFactor, (void*) &curveMatchingFactor);
        return curveMatchingFactor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SplineGenerationUtility.NativeFieldInfoPtr_MaxCurveMatchingFactor, (void*) &value);
      }
    }

    public static unsafe int MaxIterationsPerSpline
    {
      get
      {
        int iterationsPerSpline;
        IL2CPP.il2cpp_field_static_get_value(SplineGenerationUtility.NativeFieldInfoPtr_MaxIterationsPerSpline, (void*) &iterationsPerSpline);
        return iterationsPerSpline;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SplineGenerationUtility.NativeFieldInfoPtr_MaxIterationsPerSpline, (void*) &value);
      }
    }

    public static unsafe int FuturePredictionIterations
    {
      get
      {
        int predictionIterations;
        IL2CPP.il2cpp_field_static_get_value(SplineGenerationUtility.NativeFieldInfoPtr_FuturePredictionIterations, (void*) &predictionIterations);
        return predictionIterations;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SplineGenerationUtility.NativeFieldInfoPtr_FuturePredictionIterations, (void*) &value);
      }
    }

    public static unsafe int NumStepsBezierLengthMeasure
    {
      get
      {
        int bezierLengthMeasure;
        IL2CPP.il2cpp_field_static_get_value(SplineGenerationUtility.NativeFieldInfoPtr_NumStepsBezierLengthMeasure, (void*) &bezierLengthMeasure);
        return bezierLengthMeasure;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SplineGenerationUtility.NativeFieldInfoPtr_NumStepsBezierLengthMeasure, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ModuleMatchingOutput
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BestRot;
      private static readonly System.IntPtr NativeFieldInfoPtr_InPortAlignRot;
      private static readonly System.IntPtr NativeFieldInfoPtr_BestOutAxis;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalAngleDiff;
      private static readonly System.IntPtr NativeFieldInfoPtr_BestOutAngle;
      private static readonly System.IntPtr NativeFieldInfoPtr_BestOutPortIndex;
      [FieldOffset(0)]
      public Quaternion BestRot;
      [FieldOffset(16)]
      public Quaternion InPortAlignRot;
      [FieldOffset(32)]
      public Vector3 BestOutAxis;
      [FieldOffset(44)]
      public float TotalAngleDiff;
      [FieldOffset(48)]
      public float BestOutAngle;
      [FieldOffset(52)]
      public int BestOutPortIndex;

      static ModuleMatchingOutput()
      {
        Il2CppClassPointerStore<SplineGenerationUtility.ModuleMatchingOutput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SplineGenerationUtility>.NativeClassPtr, nameof (ModuleMatchingOutput));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplineGenerationUtility.ModuleMatchingOutput>.NativeClassPtr);
        SplineGenerationUtility.ModuleMatchingOutput.NativeFieldInfoPtr_BestRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineGenerationUtility.ModuleMatchingOutput>.NativeClassPtr, nameof (BestRot));
        SplineGenerationUtility.ModuleMatchingOutput.NativeFieldInfoPtr_InPortAlignRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineGenerationUtility.ModuleMatchingOutput>.NativeClassPtr, nameof (InPortAlignRot));
        SplineGenerationUtility.ModuleMatchingOutput.NativeFieldInfoPtr_BestOutAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineGenerationUtility.ModuleMatchingOutput>.NativeClassPtr, nameof (BestOutAxis));
        SplineGenerationUtility.ModuleMatchingOutput.NativeFieldInfoPtr_TotalAngleDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineGenerationUtility.ModuleMatchingOutput>.NativeClassPtr, nameof (TotalAngleDiff));
        SplineGenerationUtility.ModuleMatchingOutput.NativeFieldInfoPtr_BestOutAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineGenerationUtility.ModuleMatchingOutput>.NativeClassPtr, nameof (BestOutAngle));
        SplineGenerationUtility.ModuleMatchingOutput.NativeFieldInfoPtr_BestOutPortIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineGenerationUtility.ModuleMatchingOutput>.NativeClassPtr, nameof (BestOutPortIndex));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SplineGenerationUtility.ModuleMatchingOutput>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
